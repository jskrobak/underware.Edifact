using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.D01B.Segments;

namespace underware.Edifact.D01B.Messages
{
    public class DESADV: Message
    {
        public override BaseDocument GetDocument()
        {

            var billNo = Segments.OfType<BGM>().First().C106.E1004;
            var issueDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "137").Date;
            var deliveryDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "2").Date;
            var customer = GetParty("SG2", "BY");
            var supplier = GetParty("SG2", "SU");
            var deliveryPlace = GetParty("SG2", "DP");
            var invoicePlace = GetParty("SG2", "IV");
            var dispatchPlace = GetParty("SG2", "SH");
            var text = Segments.OfType<FTX>().FirstOrDefault(p => p.E4451 == "PUR")?.C108?.E4440;
            var messageFunction = Segments.OfType<BGM>().First().C002.E1001;
            var purchaseOrder = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "ON");
            
            var items =
                Root.FindGroups("SG17", true)
                    .Select(GetItem)
                    .ToList();
                
            var dn = new DeliveryNote()
            {
                BillNo = billNo,
                IssueDate = issueDate,
                DeliveryDate = deliveryDate,
                Customer = customer,
                Supplier = supplier,
                DeliveryPlace = deliveryPlace,
                InvoicePlace = invoicePlace,
                DispatchPlace = dispatchPlace,
                Text = text,
                MessageFunction = messageFunction,
                PurchaseOrder = purchaseOrder,
                Items = items
            };

            foreach(var item in dn.Items)
                if(item.DeliveryDate == DateTime.MinValue) item.DeliveryDate = dn.DeliveryDate;

            return dn;
        }

        private DeliverNoteItem GetItem(SegmentGroup sg17)
        {
            var lin = sg17.Segments.OfType<LIN>().FirstOrDefault();
            var qty = sg17.Segments.OfType<QTY>().FirstOrDefault();
            var imdE = sg17.Segments.OfType<IMD>().FirstOrDefault(i => i.E7077 == "E");
            var imdF = sg17.Segments.OfType<IMD>().FirstOrDefault(i => i.E7077 == "F");
            var pia = sg17.Segments.OfType<PIA>().FirstOrDefault();
            var purchaseOrder = GetReferences(sg17, "SG18", false).FirstOrDefault(r => r.Qualifier == "ON");

            return new DeliverNoteItem()
            {
                LineNo = lin?.E1082,
                GTIN = lin?.C212?.E7140,
                SupplierItemCode = pia?.C212?.E7140,
                Qty = qty.Value,
                Unit = qty?.Unit,
                PurchaseOrder = purchaseOrder,
                Name = imdE?.C273.E7008,
                //NetUnitPrice = netPrice
            };
        }

        private List<DocumentReference> GetReferences(SegmentGroup root, string groupName, bool recursive = false)
        {
            return (from @group in root.FindGroups(groupName, recursive)
                    let rff = @group.Segments.OfType<RFF>().First()
                    let dtm = @group.Segments.OfType<DTM>().FirstOrDefault()
                    select new DocumentReference()
                    {
                        Qualifier = rff.C506.E1153,
                        BillNo = rff.C506.E1154,
                        RefDate = dtm?.Date ?? DateTime.MinValue
                    })
                .ToList();
        }
        private underware.Edi.Common.DocumentModel.Party GetParty(string groupName, string qualf)
        {
            var group = Root.FindGroups(groupName).FirstOrDefault(g =>
                g.Segments.OfType<NAD>().Any() &&
                g.Segments.OfType<NAD>().First().E3035 == qualf);

            if (group == null) return null;
            
            var nad = group.Segments.OfType<NAD>().First();

            var refs = GetReferences(group,"SG3");
            var vatNo = refs.FirstOrDefault(r => r.Qualifier == "VA")?.BillNo;
            var regNo = refs.FirstOrDefault(r => r.Qualifier == "GN")?.BillNo;


            var contact = new underware.Edi.Common.DocumentModel.Party()
            {
                GLN = nad.C082?.E3039,
                Name = 
                    $"{nad.C080?.E3036}{nad.C080?.E3036_0}{nad.C080?.E3036_1}{nad.C080?.E3036_2}{nad.C080?.E3036_3}",
                Street = $"{nad.C059?.E3042}{nad.C059?.E3042_0}{nad.C059?.E3042_1}{nad.C059?.E3042_2}",
                City = nad.E3164,
                ZIPCode = nad.E3251,
                Country = nad.E3207,
                VATNo = vatNo,
                RegNo = regNo
            };
            
            
            
            return contact;
        }
    }
}