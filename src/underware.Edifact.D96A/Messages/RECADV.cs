using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.D96A.Segments;

namespace underware.Edifact.D96A.Messages
{
    public class RECADV: Message
    {
        protected override BaseDocument GetBaseDocument()
        {

            var billNo = Segments.OfType<BGM>().First().E1004;
            var issueDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "137")?.Date ?? DateTime.MinValue;
            var deliveryDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "50")?.Date ?? DateTime.MinValue;
            var customer = GetParty("SG4", "BY");
            var supplier = GetParty("SG4", "SU");
            var deliveryPlace = GetParty("SG4", "DP");
            var invoicePlace = GetParty("SG4", "IV");
            var dispatchPlace = GetParty("SG4", "SH");
            var texts = Segments.OfType<FTX>()
                .Select(p => new TextNote() { NoteType = p.E4451, Text = p?.C108?.E4440 }).ToList();
            var messageFunction = Segments.OfType<BGM>().First().C002.E1001;
            var purchaseOrder = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "ON");
            var despathAdvice = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "DQ");
            
            var items =
                Root.FindGroups("SG22", true)
                    .Select(GetItem)
                    .ToList();
                
            var recadv = new ReceivingAdvice()
            {
                BillNo = billNo,
                IssueDate = issueDate,
                DeliveryDate = deliveryDate,
                Customer = customer,
                Supplier = supplier,
                DeliveryPlace = deliveryPlace,
                InvoicePlace = invoicePlace,
                DispatchPlace = dispatchPlace,
                Texts = texts,
                MessageFunction = messageFunction,
                PurchaseOrder = purchaseOrder,
                DespatchAdvice = despathAdvice,
                Items = items
            };

            foreach (var item in recadv.Items)
            {
                if (item.DeliveryDate == DateTime.MinValue && recadv.DeliveryDate.HasValue) 
                    item.DeliveryDate = recadv.DeliveryDate.Value;
                
                if(item.PurchaseOrder == null) item.PurchaseOrder = recadv.PurchaseOrder;
                if(item.DespatchAdvice == null) item.DespatchAdvice = recadv.DespatchAdvice;
            }

            return recadv;
        }

        private ReceivingAdviceItem GetItem(SegmentGroup sg22)
        {
            var lin = sg22.Segments.OfType<LIN>().FirstOrDefault();
            var qtyOrd = sg22.Segments.OfType<QTY>().FirstOrDefault(q => q.Qualifier == "46");
            var qtyRec = sg22.Segments.OfType<QTY>().FirstOrDefault(q => q.Qualifier == "194");
            var piaSA = sg22.Segments.OfType<PIA>().FirstOrDefault(p => p.C212.E7143 == "SA");
            var piaIN = sg22.Segments.OfType<PIA>().FirstOrDefault(p => p.C212.E7143 == "IN");
            
            var purchaseOrder = GetReferences(sg22, "SG23", false).FirstOrDefault(r => r.Qualifier == "ON");
            var despatchAdvice = GetReferences(sg22, "SG23", false).FirstOrDefault(r => r.Qualifier == "DQ");

            
            return new ReceivingAdviceItem()
            {
                LineNo = lin?.E1082,
                GTIN = lin?.C212?.E7140,
                SupplierItemCode = piaSA?.C212?.E7140,
                CustomerItemCode = piaIN?.C212?.E7140,
                OrderedQty = qtyOrd?.Value,
                Unit = qtyOrd?.Unit,
                ReceivedQty = qtyRec.Value,
                PurchaseOrder = purchaseOrder,
                Name = piaIN?.C212_0?.E7140,
                DespatchAdvice = despatchAdvice
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