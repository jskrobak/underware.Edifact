//A few examples how to use underware.Edifact framework


using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using underware.Edifact;
using underware.Edifact.D96A;
using underware.Edifact.D96A.Segments;
using underware.Edifact.Security;
using underware.Edifact.Xml;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


//Parse Edifact file from Samples.
ParseEdifact();

//Create Edifact ORDERS from scratch
CreateEdifact();




//Parse Edifact file from Samples.  
//You need reference underware.Edifact.D??? project for every EDIFACT release ned version you want to use.  
void ParseEdifact()
{
    //choose encoding. You can use ASCII, UTF-8, whatever
    Encoding cp1250 = Encoding.GetEncoding(1250);

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
    Console.WriteLine(supplierName);

}


//In this example you can create new D96A ORDERS interchange 
void CreateEdifact()
{
    //create interchange envelope
    
    string sender = "SENDERID";
    string receiver = "RECEIVERID";
    string interchangeId = "123456";
    bool isTest = true;
    
    Interchange edifact = new Interchange(CharSpec.Default,
        Syntax.UNOD3,
        Party.EAN(sender),
        Party.EAN(receiver),
        interchangeId,
        "ORDERS",
        false);

    
    //Create first ORDERS message header
    
    string billNo = "123456";
    DateTime deliveryDate = DateTime.Now.AddDays(3);
    DateTime issueDate = DateTime.Now;
    string note = "Order note";
    var customerGLN = "customerGLN";
    var customerName = "customerName";
    var deliveryPlaceGLN = "deliveryPlaceGLN";
    var deliveryPlaceName = "deliveryPlaceName";
    var invoiceToGLN = "customerName";
    var invoiceToName = "customerName";
    var supplierGLN = "customerName";
    var supplierName = "customerName";
    
    string refNo = "123456001";
    
    Message msg = new Message(3, "ORDERS", "D", "96A", "UN", "EAN008", refNo);

    msg.Segments.Add(Templates.BGM("220", billNo));
    msg.Segments.Add(Templates.DTM("137", issueDate, DateTimeFormat.DT102));
    msg.Segments.Add(Templates.DTM("2", deliveryDate, DateTimeFormat.DT102));
    msg.Segments.Add(Templates.FTX("AAI", note));
    msg.Segments.Add(Templates.NAD("BY", customerGLN, customerName, "", "", "", ""));
    msg.Segments.Add(Templates.NAD("DP", deliveryPlaceGLN, deliveryPlaceName, "", "", "", ""));
    msg.Segments.Add(Templates.NAD("IV", invoiceToGLN, invoiceToName, "", "", "", ""));
    msg.Segments.Add(Templates.NAD("SU", supplierGLN, supplierName, "", "", "", ""));
    
    //add 1 order item

    string itemNumber = "1";
    string gtin = "GTIN";
    decimal qty = 1;
    string unit = "PCE";
    string name = "Item name";
    string customerItemCode = "customerItemCode";
    string supplierItemCode = "supplierItemCode";
    DateTime itemDeliveryDate = DateTime.Now.AddDays(3);

    msg.Segments.Add(Templates.LIN(itemNumber, gtin, "EN"));
    msg.Segments.Add(Templates.PIA("5", supplierItemCode, "ZZZ"));
    msg.Segments.Add(Templates.IMD("F", "", name));
    msg.Segments.Add(Templates.QTY("21", qty, unit));
    
    
    //format trailer
    msg.Segments.Add(Templates.UNS());

    //add message into interchange
    edifact.Messages.Add(msg);
    
    //write out edifact 
    Console.Write(edifact.ToString());
}

