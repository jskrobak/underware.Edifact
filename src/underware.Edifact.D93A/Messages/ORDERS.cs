
using System;
using System.Collections.Generic;
using System.Linq;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.D93A.Segments;

namespace underware.Edifact.D93A.Messages
{
    public class ORDERS : Message
    {
        protected override BaseDocument GetBaseDocument()
        {
            var order = new Order()
            {
                BillNo = Segments.OfType<BGM>().First().E1004,
                IssueDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "137").Date,
                DeliveryDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "2").Date,
                Customer = GetParty("SG2", "BY"),
                Supplier = GetParty("SG2", "SU"),
                DeliveryPlace = GetParty("SG2", "DP"),
                InvoicePlace = GetParty("SG2", "IV"),
                DispatchPlace = GetParty("SG2", "SH"),
                MessageFunction = Segments.OfType<BGM>().First().C002.E1001,
                Items =
                    Root.FindGroups("SG25", true)
                        .Select(GetOrderItem)
                        .ToList(),
                Texts = Segments.OfType<FTX>()
                    .Select(ftx => new TextNote() { NoteType = ftx.E4451, Text = ftx?.C108.E4440 }).ToList(),
            };
            
            
            
            foreach(var item in order.Items)
                if(item.DeliveryDate == DateTime.MinValue) item.DeliveryDate = order.DeliveryDate;


            return order;
        }

        
        private OrderItem GetOrderItem(SegmentGroup sg)
        {
            var lin = sg.Segments.OfType<LIN>().FirstOrDefault();
            var qty = sg.Segments.OfType<QTY>().FirstOrDefault();
            var dtm = sg.Segments.OfType<DTM>().FirstOrDefault(d=>d.Qualifier == "2");
            var imd = sg.Segments.OfType<IMD>().FirstOrDefault();
            var pia = sg.Segments.OfType<PIA>().FirstOrDefault();

            return new OrderItem()
            {
                LineNo = lin?.E1082,
                GTIN = lin.C212.E7140,
                SupplierItemCode = pia.C212.E7140,
                Qty = qty.Value,
                Unit = qty.Unit,
                DeliveryDate = dtm?.Date ?? DateTime.MinValue,
                Name = imd.C273.E7008
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
                        RefDate = dtm.Date
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
                Street = $"{nad.C059?.E3042}{nad.C059?.E3042_0}{nad.C059?.E3042_1}",
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