using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.D07A.Segments;
using underware.Edifact.Xml;

namespace underware.Edifact.D07A.Messages.UNGAVA10;

public class INVOIC : Message
    {
        protected override BaseDocument GetBaseDocument()
        { 
            //var xml = Root.ToXml();

            var billNo = Segments.OfType<BGM>().First().C106.E1004;
            var issueDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "137").Date;
            var fulfillmentDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "325")?.Date ?? issueDate;
            var customer = GetParty("SG2", "BY");
            var supplier = GetParty("SG2", "SE")??GetParty("SG2", "SE");
            var deliveryPlace = GetParty("SG34", "CN");
            var invoicePlace = GetParty("SG2", "IV");
            var dispatchPlace = GetParty("SG2", "SF");
            var texts = Segments.OfType<FTX>()
                .Select(p => new TextNote() { NoteType = p.E4451, Text = p?.C108?.E4440 }).ToList();
            var messageFunction = Segments.OfType<BGM>().First().E1225;
            var invoiceType = Segments.OfType<BGM>().First().C002.E1001;
            var desadv = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "DQ");
            var purchaseOrder = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "ON");
            var refInvoice = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "IV");
            var contract = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "CT");
            var currency = Segments.OfType<CUX>().FirstOrDefault()?.C504.E6345;

            var items =
                Root.FindGroups("SG26", true)
                    .Select(GetInvoiceItem)
                    .ToList();

            var paymentRules = new PaymentRules
            {
                DueDate = AllSegments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "140").Date
            };//GetPaymentRules();}

            var inv = new Invoice()
            {
                BillNo = billNo,
                IssueDate = issueDate,
                Customer = customer,
                Supplier = supplier,
                DeliveryPlace = deliveryPlace,
                InvoicePlace = invoicePlace,
                DispatchPlace = dispatchPlace,
                Texts = texts,
                MessageFunction = messageFunction,
                Items = items,
                FulfillmentDate = fulfillmentDate,
                InvoiceType = invoiceType,
                DespatchAdvice = desadv,
                PaymentRules = paymentRules,
                PurchaseOrder = purchaseOrder,
                RefInvoice = refInvoice,
                Currency = currency,
                Taxes = new List<Tax>(),
                Contract = contract
            };

            foreach (var moa in Root.FindGroups("SG48").SelectMany(sg48 => sg48.Segments.OfType<MOA>()))
            {
                switch (moa.Qualifier)
                {
                    case "125":
                        inv.Round = moa.Amount?? 0;
                        break;
                    case "79":
                        inv.TotalAmount = moa.Amount?? 0;
                        break;
                    case "77":
                        inv.TotalAmountIncVAT = moa.Amount ?? 0;
                        break;
                }
            }

            if (inv.TotalAmount != 0 && inv.TotalAmountIncVAT == 0)
            {
                inv.TotalAmountIncVAT = inv.TotalAmount + inv.Taxes.Sum(t => t.Amount);
            }

            inv.DespatchAdvice ??= inv.Items.FirstOrDefault()?.DespatchAdvice;
            
            inv.PurchaseOrder ??= inv.Items.FirstOrDefault()?.PurchaseOrder;

            return inv;
        }

        private InvoiceItem GetInvoiceItem(SegmentGroup sg)
        {
            var lin = sg.Segments.OfType<LIN>().FirstOrDefault();
            var qty = sg.Segments.OfType<QTY>().FirstOrDefault(q => q.Qualifier == "47");
            var imd = sg.Segments.OfType<IMD>().FirstOrDefault();

            var name = imd?.C273?.E7008;

            var purchaseOrder = GetReferences(sg, "SG30", false).FirstOrDefault(r => r.Qualifier == "ON");
            var dispatchAdvice = GetReferences(sg, "SG30", false).FirstOrDefault(r => r.Qualifier == "AAK");
            var refInvoice = GetReferences(sg, "SG30", false).FirstOrDefault(r => r.Qualifier == "IV");

            var item = new InvoiceItem()
            {
                LineNo = lin?.E1082,
                GTIN = lin?.C212?.E7140,
                CustomerItemCode = lin?.C212?.E7140,
                Qty = qty.Value,
                Unit = qty?.Unit,
                Name = name,
                //DeliveryDate = dtm?.Date ?? DateTime.MinValue,
                PurchaseOrder = purchaseOrder,
                RefInvoice = refInvoice,
                DespatchAdvice = dispatchAdvice,
                //PcePerUnitQty = qty59?.Value,
            };

            var sg27 = sg.Groups.FirstOrDefault(g => g.Name == "SG27");
            var moa203 = sg27?.Segments.OfType<MOA>().FirstOrDefault(m => m.Qualifier == "203");
            var moa66 = sg27?.Segments.OfType<MOA>().FirstOrDefault(m => m.Qualifier == "66");
            item.Price = moa203?.Amount ?? moa66?.Amount ?? 0;

            foreach (var sg29 in sg.FindGroups("SG29", true))
            {
                var pri = sg29.Segments.OfType<PRI>().FirstOrDefault();

                if (decimal.TryParse(pri.C509?.E5118, NumberStyles.Any, CultureInfo.InvariantCulture,
                        out var unitPrice))
                {
                    if (pri.C509.E5125 == "AAB")
                        item.UnitPriceGross = unitPrice;

                    if (pri.C509.E5125 == "AAA")
                        item.UnitPriceNet = unitPrice;
                }
            }

            var sg34 = sg.Groups.FirstOrDefault(g => g.Name == "SG34");
            if (sg34 == null) return item;
            
            var tax = sg34.Segments.OfType<TAX>().FirstOrDefault(t => t.C241.E5153 == "VAT");

            if (decimal.TryParse(tax.C243?.E5279, NumberStyles.Any, CultureInfo.InvariantCulture, out var vatRate))
            {
                item.VATRate = vatRate;
            }

            return item;


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
            var group = Root.FindGroups(groupName, true).FirstOrDefault(g =>
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