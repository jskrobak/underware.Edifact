using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.D01B.Segments;
using underware.Edifact.Xml;

namespace underware.Edifact.D01B.Messages
{
    public class INVOIC : Message
    {
        protected override BaseDocument GetBaseDocument()
        {
            var xml = Root.ToXml();

            var billNo = Segments.OfType<BGM>().First().C106.E1004;
            var issueDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "137").Date;
            var fulfillmentDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "325").Date;
            var deliveryDate = Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "35")?.Date ?? DateTime.MinValue;
            var customer = GetParty("SG2", "BY");
            var supplier = GetParty("SG2", "SU");
            var deliveryPlace = GetParty("SG2", "DP");
            var invoicePlace = GetParty("SG2", "IV");
            var dispatchPlace = GetParty("SG2", "SH");
            var text = Segments.OfType<FTX>().FirstOrDefault(p => p.E4451 == "ZZZ")?.C108?.E4440;
            var messageFunction = Segments.OfType<BGM>().First().E1225;
            var invoiceType = Segments.OfType<BGM>().First().C002.E1001;
            var desadv = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "DQ");
            var purchaseOrder = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "ON");
            var salesOrder = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "VN");
            var refInvoice = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "IV");
            var contract = GetReferences(Root, "SG1", false).FirstOrDefault(r => r.Qualifier == "CT");
            var currency = Segments.OfType<CUX>().FirstOrDefault()?.C504.E6345;
            
            var texts = Segments.OfType<FTX>().Select(p => new TextNote(){NoteType = p.E4451, Text = p?.C108?.WholeText}).ToList();
            
            var items =
                Root.FindGroups("SG26", true)
                    .Select(GetInvoiceItem)
                    .ToList();

            var paymentRules = GetPaymentRules();
            
            var taxes = Root.FindGroups("SG52").Select(GetTax).ToList();
            
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
                Taxes = taxes,
                Contract = contract
            };

            foreach (var sg50 in Root.FindGroups("SG50"))
            {
                foreach (var moa in sg50.Segments.OfType<MOA>())
                {
                    switch (moa.C516.E5025)
                    {
                        case "165":
                            inv.Round = decimal.Parse(moa.C516.E5004, NumberStyles.Any, CultureInfo.InvariantCulture);
                            break;
                        case "79":
                            inv.TotalAmount = decimal.Parse(moa.C516.E5004, NumberStyles.Any,
                                CultureInfo.InvariantCulture);
                            break;
                        case "86":
                            inv.TotalAmountIncVAT = decimal.Parse(moa.C516.E5004, NumberStyles.Any,
                                CultureInfo.InvariantCulture);
                            break;
                        case "9":
                            inv.ToPay = decimal.Parse(moa.C516.E5004, NumberStyles.Any,
                                CultureInfo.InvariantCulture);
                            break;
                        case "176":
                            inv.Taxes.Add(new Tax()
                            {
                                TaxType = "VAT",
                                Code = "",
                                Amount = decimal.Parse(moa.C516.E5004, NumberStyles.Any,
                                    CultureInfo.InvariantCulture)
                            });
                            break;
                    }
                }
            }

            foreach (var item in inv.Items)
            {
                if (string.IsNullOrEmpty(item.PurchaseOrder?.BillNo)) item.PurchaseOrder = inv.PurchaseOrder;
                if (string.IsNullOrEmpty(item.DespatchAdvice?.BillNo)) item.DespatchAdvice = inv.DespatchAdvice;
            }

            return inv;
        }

        private Tax GetTax(SegmentGroup sg)
        {
            var tax = sg.Segments.OfType<TAX>().FirstOrDefault();
            var moa125 = sg.Segments.OfType<MOA>().FirstOrDefault(m => m.C516.E5025 == "125");
            var moa124 = sg.Segments.OfType<MOA>().FirstOrDefault(m => m.C516.E5025 == "124");

            decimal.TryParse(tax.C243?.E5278, NumberStyles.Any, CultureInfo.InvariantCulture, out var rate);
            var basis = !string.IsNullOrEmpty(tax.E5286)
                ? decimal.Parse(tax.E5286, NumberStyles.Any, CultureInfo.InvariantCulture)
                : 0;
            var amount = 0m;


            basis = !string.IsNullOrEmpty(tax.E5286)
                ? decimal.Parse(tax.E5286, NumberStyles.Any, CultureInfo.InvariantCulture)
                : moa125?.C516?.E5004 == null ? 0 : decimal.Parse(moa125.C516.E5004, NumberStyles.Any, CultureInfo.InvariantCulture);

            if(moa124?.C516?.E5004 != null)
                amount = decimal.Parse(moa124?.C516?.E5004, NumberStyles.Any, CultureInfo.InvariantCulture);


            return new Tax
            {
                TaxType = tax.C241.E5153,
                Code = tax.C243?.E5279,
                Rate = rate,
                Amount = amount,
                Basis = basis
            };
        }

        private PaymentRules GetPaymentRules()
        {
            var paymentType = Root.Segments.OfType<PAI>().FirstOrDefault()?.C534?.E4461;
            var sg2 = Root.FindGroups("SG2").FirstOrDefault(g =>
                g.Segments.OfType<NAD>().Any() &&
                g.Segments.OfType<NAD>().First().E3035 == "SU");
            
            var fii = sg2.Segments.OfType<FII>().First();
            
            var sg8 = Root.FindGroups("SG8").FirstOrDefault();
            
            var dueDate = sg8.Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "13").Date;
            
            return new PaymentRules()
            {
                BankCode = fii.C088.E3433,
                BankAccountNo = fii.C078.E3194,
                VariableSymbol = fii.C078.E3192_0,
                ConstantSymbol = fii.C078.E3192,
                SpecificSymbol = fii.C078.E6345,
                DueDate = dueDate,
                PaymentType = paymentType
            };
        }
        
        private InvoiceItem GetInvoiceItem(SegmentGroup sg26)
        {
            var lin = sg26.Segments.OfType<LIN>().FirstOrDefault();
            var qty47 = sg26.Segments.OfType<QTY>().FirstOrDefault(q => q.Qualifier == "47");
            var qty59 = sg26.Segments.OfType<QTY>().FirstOrDefault(q => q.Qualifier == "59");
            var dtm = sg26.Segments.OfType<DTM>().FirstOrDefault(d=>d.Qualifier == "35");
            var imdE = sg26.Segments.OfType<IMD>().FirstOrDefault(i => i.E7077 == "E");
            var imdF = sg26.Segments.OfType<IMD>().FirstOrDefault(i => i.E7077 == "F");
            var piaSA = sg26.Segments.OfType<PIA>().FirstOrDefault(p => p.C212.E7143 == "SA");
            var piaIN = sg26.Segments.OfType<PIA>().FirstOrDefault(p => p.C212.E7143 == "IN");
            
            var purchaseOrder = GetReferences(sg26, "SG30", false).FirstOrDefault(r => r.Qualifier == "ON");
            var despatchAdvice = GetReferences(sg26, "SG30", false).FirstOrDefault(r => r.Qualifier == "DQ");
            var refInvoice = GetReferences(sg26, "SG30", false).FirstOrDefault(r => r.Qualifier == "IV");

            var item = new InvoiceItem()
            {
                LineNo = lin?.E1082,
                GTIN = lin?.C212?.E7140,
                SupplierItemCode = piaSA?.C212?.E7140,
                CustomerItemCode = piaIN?.C212?.E7140,
                Qty = qty47.Value,
                Unit = qty47?.Unit,
                ItemType = imdF?.C273?.E7008,
                Name  = imdE?.C273?.E7008_Whole,
                DeliveryDate = dtm?.Date ?? DateTime.MinValue,
                PurchaseOrder = purchaseOrder,
                RefInvoice = refInvoice,
                DespatchAdvice = despatchAdvice,
                PcePerUnitQty = qty59?.Value ?? 0
            };
            
            var texts = new List<TextNote>();
            
            var zzzNote = GetReferences(sg26, "SG30", false).FirstOrDefault(r => r.Qualifier == "ZZZ");
            if (zzzNote != null)
                item.Texts = new List<TextNote> { new TextNote() { NoteType = "ZZZ", Text = zzzNote.BillNo } };
            
            var sg27 = sg26.Groups.FirstOrDefault(g => g.Name == "SG27");
            var moa203 = sg27?.Segments.OfType<MOA>().FirstOrDefault(m => m.C516.E5025 == "203");

            if (decimal.TryParse(moa203.C516.E5004,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out var price))
            {
                item.Price = price;
            }
            
            foreach(var sg29 in sg26.FindGroups("SG29", true))
            {
                var pri = sg29.Segments.OfType<PRI>().FirstOrDefault();
                
                if (decimal.TryParse(pri.C509?.E5118, NumberStyles.Any, CultureInfo.InvariantCulture, out var unitPrice))
                {
                    if(pri.C509.E5125 == "AAB")
                        item.UnitPriceGross = unitPrice;

                    if (pri.C509.E5125 == "AAA")
                        item.UnitPriceNet = unitPrice;
                }
            }

            var sg34 = sg26.Groups.FirstOrDefault(g => g.Name == "SG34");
            var tax = sg34.Segments.OfType<TAX>().FirstOrDefault(t => t.C241.E5153 == "VAT");
            
            if (decimal.TryParse(tax.C243?.E5278, NumberStyles.Any, CultureInfo.InvariantCulture, out var vatRate))
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
                        RefDate = dtm?.NullableDate
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