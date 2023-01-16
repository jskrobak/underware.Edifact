using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95A.Composites;

namespace underware.Edifact.D95A.Segments
{
    public class VLI : Segment
    {
        public VLI() : base("VLI", "Value list identification"){}

				[ElementInfo(0, "VALUE LIST IDENTIFICATION", "M", "1", "", "" )]
public C780 C780 { get; set; }
		[ElementInfo(1, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "" )]
public C082 C082 { get; set; }
		[ElementInfo(2, "Status, coded", "C", "1", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(3, "Value list name", "C", "1", "an..70", "" )]
public string E1514 { get; set; }
		[ElementInfo(4, "Class designator, coded", "C", "1", "an..3", "" )]
public string E1507 { get; set; }
		[ElementInfo(5, "Value list type, coded", "C", "1", "an..3", "" )]
public string E1505 { get; set; }
		[ElementInfo(6, "PRODUCT CHARACTERISTIC", "C", "1", "", "" )]
public C240 C240 { get; set; }
		[ElementInfo(7, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}