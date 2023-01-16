using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;

namespace underware.Edifact.D96A.Segments
{
    public class ALC : Segment
    {
        public ALC() : base("ALC", "Allowance or charge"){}

				[ElementInfo(0, "Allowance or charge qualifier", "M", "1", "an..3", "" )]
public string E5463 { get; set; }
		[ElementInfo(1, "ALLOWANCE/CHARGE INFORMATION", "C", "1", "", "" )]
public C552 C552 { get; set; }
		[ElementInfo(2, "Settlement, coded", "C", "1", "an..3", "" )]
public string E4471 { get; set; }
		[ElementInfo(3, "Calculation sequence indicator, coded", "C", "1", "an..3", "" )]
public string E1227 { get; set; }
		[ElementInfo(4, "SPECIAL SERVICES IDENTIFICATION", "C", "1", "", "" )]
public C214 C214 { get; set; }

		
    }
}