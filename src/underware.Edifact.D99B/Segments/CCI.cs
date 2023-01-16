using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class CCI : Segment
    {
        public CCI() : base("CCI", "Characteristic/class id"){}

				[ElementInfo(0, "Class type code", "C", "1", "an..3", "" )]
public string E7059 { get; set; }
		[ElementInfo(1, "MEASUREMENT DETAILS", "C", "1", "", "" )]
public C502 C502 { get; set; }
		[ElementInfo(2, "PRODUCT CHARACTERISTIC", "C", "1", "", "" )]
public C240 C240 { get; set; }
		[ElementInfo(3, "Characteristic relevance, coded", "C", "1", "an..3", "" )]
public string E4051 { get; set; }

		
    }
}