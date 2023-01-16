using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class ALI : Segment
    {
        public ALI() : base("ALI", "ADDITIONAL INFORMATION"){}

				[ElementInfo(0, "COUNTRY OF ORIGIN IDENTIFIER", "Conditional", "", "", "" )]
public string E3239 { get; set; }
		[ElementInfo(1, "DUTY REGIME TYPE CODE", "Conditional", "", "", "" )]
public string E9213 { get; set; }
		[ElementInfo(2, "SPECIAL CONDITION CODE", "Conditional", "", "", "" )]
public string E4183 { get; set; }
		[ElementInfo(3, "SPECIAL CONDITION CODE", "Conditional", "", "", "" )]
public string E4183_0 { get; set; }
		[ElementInfo(4, "SPECIAL CONDITION CODE", "Conditional", "", "", "" )]
public string E4183_1 { get; set; }
		[ElementInfo(5, "SPECIAL CONDITION CODE", "Conditional", "", "", "" )]
public string E4183_2 { get; set; }
		[ElementInfo(6, "SPECIAL CONDITION CODE", "Conditional", "", "", "" )]
public string E4183_3 { get; set; }

		
    }
}