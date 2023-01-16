# underware.Edifact
Framework for parsing and processing EDIFACT in .Net

You can parse EDIFACT interchange into object structure. Export it into the xml or search data via Linq.

```c#
//Load interchange from file
Interchange itr = Interchange.FromFile(@"Samples\D96A_INVOIC.txt", cp1250);
    
//export whole interchange into xml
var xml = itr.ToXml();
Console.WriteLine(xml);
    
//export first message of interchange into xml
SegmentGroup sg = itr.Messages[0].CreateTree();
Console.WriteLine(itr.Messages[0].CreateTree().ToXml());

//find supplier 
string supplierName = itr.Messages.First().AllSegments.OfType<NAD>().Where(s => s.Qualifier == "SU").First().PartyName;
```



You can also simply create EDIFACT interchange from scratch 

```c#
//create interchange envelope
Interchange edifact = new Interchange(CharSpec.Default,
        Syntax.UNOD3,
        Party.EAN(sender),
        Party.EAN(receiver),
        interchangeId,
        "ORDERS",
        false);
        
Message msg = new Message(3, "ORDERS", "D", "96A", "UN", "EAN008", refNo);

msg.Segments.Add(Templates.BGM("220", billNo));
 
msg.Segments.Add(Templates.UNS());

//add message into interchange
edifact.Messages.Add(msg);
```        


See more in underware.Edifact.Examples project 
