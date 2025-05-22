using System;
using System.Collections.Generic;
using System.Linq;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.D96A.Segments;
using underware.Edifact.Xml;

namespace underware.Edifact.D96A.Messages;

public class DELFOR: Message
{
    protected override BaseDocument GetBaseDocument()
    {
        //var xml = Root.ToXml();
        
        var delfor = new DeliveryForecast()
        {
            BillNo = Segments.OfType<BGM>().First().E1004,
            Customer = GetParty("SG2", "BY"),
            DeliveryPlace = GetParty("SG4", "CN"),
            Supplier = GetParty("SG2", "SE"),
            Items = Root.FindGroups("SG8", true)
                .Select(GetItem)
                .ToList()
        };
        
        return delfor;
    }

    private static DeliveryForecastItem GetItem(SegmentGroup sg)
    {
        var references = sg.FindGroups("SG10").Select(sg =>
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
        
        var quantities = sg.FindGroups("SG12")
            .SelectMany(sg12 => sg12.Segments.OfType<QTY>())
            .ToList();

        var firstSg12WithSg13 = sg
            .FindGroups("SG12").FirstOrDefault(group => group.Groups.Any(s => s.Name == "SG13"));
        
        
        //var receivedQantities = sg.FindGroups("SG12")
        //    .Where(group => group.Segments.OfType<QTY>().Any(qty => qty.Qualifier == "48"))
         //   .ToList();

        var sg13 = firstSg12WithSg13.Groups.FirstOrDefault(s => s.Name == "SG13"); //. First()..Select(group =>
        
        var lastDeliveryNote = new DocumentReference
            {
                BillNo = sg13.Segments.OfType<RFF>().FirstOrDefault()?.Value,
                RefDate = sg13.Segments.OfType<DTM>().FirstOrDefault()?.Date
            };
            
        var item = new DeliveryForecastItem
        {
            CalculationDate = sg.Segments.OfType<DTM>().FirstOrDefault(d => d.Qualifier == "257")?.Date,
            LastReceivedQty = firstSg12WithSg13.Segments.OfType<QTY>().FirstOrDefault()?.Value,
            LastReceivedDeliveryNoteNo = sg13.Segments.OfType<RFF>().FirstOrDefault()?.Value,
            LastReceivedDeliveryNoteDate = sg13.Segments.OfType<DTM>().FirstOrDefault()?.Date,
            DeliveryScheduleNumberOld = references.FirstOrDefault(s => s.Qualifier == "AIF")?.BillNo,
            DeliveryScheduleDateOld = references.FirstOrDefault(s => s.Qualifier == "AIF").RefDate,
            PlaceOfDischarge = sg.Segments.OfType<LOC>().FirstOrDefault(x => x.E3227 == "11")?.C517?.E3225,
            PlaceOfDelivery = sg.Segments.OfType<LOC>().FirstOrDefault(x => x.E3227 == "159")?.C517?.E3225,
            PartNumber = sg.Segments.OfType<LIN>().FirstOrDefault()?.C212.E7140,
            OrderNo = references.FirstOrDefault(s => s.Qualifier == "ON")?.BillNo,
            BackorderQty = quantities.FirstOrDefault(q => q.Qualifier == "83")?.Value,
            CumulativeQtyReceived = quantities.FirstOrDefault(q => q.Qualifier == "70")?.Value,
        };


        foreach(var sg12 in sg.FindGroups("SG12")
                    .Where(sg12 => sg12.Segments.OfType<DTM>()
                        .Any(d => d.Qualifier == "2")))
        {
           item.Deliveries.Add(new Delivery
           {
               Date = sg12.Segments.OfType<DTM>().FirstOrDefault().Date,
               Qty = sg12.Segments.OfType<QTY>().FirstOrDefault().Value
           });
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
        var group = Root.FindGroups(groupName).FirstOrDefault(g =>
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