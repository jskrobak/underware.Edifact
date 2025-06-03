using System;
using System.Collections.Generic;
using System.Linq;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.D04A.Segments;
using underware.Edifact.Xml;

namespace underware.Edifact.D04A.Messages.UNGAVB11;

public class DELFOR: Message
{
    protected override BaseDocument GetBaseDocument()
    {
        //var xml = Root.ToXml();
        
        var delfor = new DeliveryForecast()
        {
            BillNo = Segments.OfType<BGM>().First().C106.E1004,
            Customer = GetParty("SG2", "BY"),
            DeliveryPlace = GetParty("SG7", "ST"),
            Supplier = GetParty("SG2", "SE")
        };

        foreach (var sg6 in Root.FindGroups("SG6", true))
        {
            var sg7 = sg6.FindGroups("SG7").FirstOrDefault();
            
            var placeOfDischarge = sg7.Segments.OfType<LOC>().FirstOrDefault(loc => loc.E3227 == "11").C517.E3225;
            //XmlHelper.GetString(sg6, "SG7[NAD/@E3035='ST']/LOC[@E3227='11']/C517/@E3225");
            
            var placeOfDelivery =  sg7.Segments.OfType<LOC>().FirstOrDefault(loc => loc.E3227 == "11").C517.E3225;
            //XmlHelper.GetString(sg6, "SG7[NAD/@E3035='ST']/LOC[@E3227='7']/C517/@E3225");
            
            foreach(var sg12 in sg6.FindGroups("SG12"))
            {
                var item = GetItem(sg12);
                
                item.PlaceOfDischarge = placeOfDischarge;
                item.PlaceOfDelivery = placeOfDelivery;
                
                delfor.Items.Add(item);
            }
        }
            
        
        return delfor;
    }

    private static DeliveryForecastItem GetItem(SegmentGroup sg)
    {
        var references = sg.FindGroups("SG13").Select(sg =>
        {
            var rff = sg.Segments.OfType<RFF>().FirstOrDefault();
            var dtm = sg.Segments.OfType<DTM>().FirstOrDefault();
            
            return new DocumentReference
            {
                Qualifier = rff.Qualifier,
                BillNo = rff.Value,
                RefDate = dtm?.Date
            };
        });
        
        var quantities = sg.FindGroups("SG16")
            .SelectMany(sg16 => sg16.Segments.OfType<QTY>())
            .ToList();

        var firstSg16WithSg17 = sg
            .FindGroups("SG16").FirstOrDefault(group => group.Groups.Any(s => s.Name == "SG17"));
        
        var lastSg16WithSg17 = sg
            .FindGroups("SG16").LastOrDefault(group => group.Groups.Any(s => s.Name == "SG17"));
        //var receivedQantities = sg.FindGroups("SG12")
        //    .Where(group => group.Segments.OfType<QTY>().Any(qty => qty.Qualifier == "48"))
         //   .ToList();

        var sg17 = firstSg16WithSg17?.Groups.FirstOrDefault(s => s.Name == "SG17"); //. First()..Select(group =>
            
        var item = new DeliveryForecastItem
        {
            CalculationDate = lastSg16WithSg17?.Segments.OfType<DTM>().FirstOrDefault()?.Date,
            LastReceivedQty = firstSg16WithSg17?.Segments.OfType<QTY>().FirstOrDefault()?.Value,
            LastReceivedDeliveryNoteNo = sg17?.Segments.OfType<RFF>().FirstOrDefault()?.Value,
            LastReceivedDeliveryNoteDate = sg17?.Segments.OfType<DTM>().FirstOrDefault()?.Date,
            DeliveryScheduleNumberNew = references.FirstOrDefault(s => s.Qualifier == "AAN")?.BillNo,
            DeliveryScheduleDateNew = references.FirstOrDefault(s => s.Qualifier == "AAN")?.RefDate,
            DeliveryScheduleNumberOld = references.FirstOrDefault(s => s.Qualifier == "AIF")?.BillNo,
            DeliveryScheduleDateOld = references.FirstOrDefault(s => s.Qualifier == "AIF").RefDate,
            PlaceOfDischarge = sg.Segments.OfType<LOC>().FirstOrDefault(x => x.E3227 == "11")?.C517?.E3225,
            PlaceOfDelivery = sg.Segments.OfType<LOC>().FirstOrDefault(x => x.E3227 == "159")?.C517?.E3225,
            PartNumber = sg.Segments.OfType<LIN>().FirstOrDefault()?.C212.E7140,
            OrderNo = references.FirstOrDefault(s => s.Qualifier == "ON")?.BillNo,
            BackorderQty = quantities.FirstOrDefault(q => q.Qualifier == "83")?.Value,
            CumulativeQtyReceived = quantities.FirstOrDefault(q => q.Qualifier == "70")?.Value,
        };

        foreach (var sg18 in sg.FindGroups("SG18"))
        {
            var sccType = sg18.Segments.OfType<SCC>().FirstOrDefault()?.E4017;

            foreach (var sg19 in sg18.FindGroups("SG19"))
            {
                var firstDate = sg19.Segments.OfType<DTM>().FirstOrDefault();
                var secondDate = sg19.Segments.OfType<DTM>().Skip(1).FirstOrDefault();
                
                var delivery = new Delivery
                {
                    Date = firstDate.Date,
                    EndDate = secondDate?.Date,
                    Qty = sg19.Segments.OfType<QTY>().FirstOrDefault().Value,
                    SpecialMeaning = sccType == "10" ? SpecialDateMeaning.Immediate : SpecialDateMeaning.None 
                };
                
                item.Deliveries.Add(delivery);
            }
            
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
                    RefDate = dtm == null ? null : new DateTime?(dtm.Date)
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
        var addId = refs.FirstOrDefault(r => r.Qualifier == "IA")?.BillNo;

        var sg5 = group.FindGroups("SG5").FirstOrDefault();
        var ctaContact = sg5?.Segments.OfType<CTA>().FirstOrDefault()?.C056?.E3412;
        var email = sg5?.Segments.OfType<COM>().FirstOrDefault(x => x.C076.E3155 == "EM")?.C076.E3148;
        var phone = sg5?.Segments.OfType<COM>().FirstOrDefault(x => x.C076.E3155 == "TE")?.C076.E3148;

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
            RegNo = regNo,
            ExternalCode = addId,
            Email = email,
            Phone1 = phone,
            Contact = ctaContact
        };
            
            
            
        return contact;
    }
}