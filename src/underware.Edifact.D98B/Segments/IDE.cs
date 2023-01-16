using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class IDE : Segment
    {
        public IDE() : base("IDE", "Identity"){}

				[ElementInfo(0, "Identification qualifier", "M", "1", "an..3", "" )]
public string E7495 { get; set; }
		[ElementInfo(1, "IDENTIFICATION NUMBER", "M", "1", "", "" )]
public C206 C206 { get; set; }
		[ElementInfo(2, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "" )]
public C082 C082 { get; set; }
		[ElementInfo(3, "Status, coded", "C", "1", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(4, "Configuration level", "C", "1", "n..2", "" )]
public string E1222 { get; set; }
		[ElementInfo(5, "POSITION IDENTIFICATION", "C", "1", "", "" )]
public C778 C778 { get; set; }
		[ElementInfo(6, "PRODUCT CHARACTERISTIC", "C", "1", "", "" )]
public C240 C240 { get; set; }

		
    }
}