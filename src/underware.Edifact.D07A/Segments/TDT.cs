using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class TDT : Segment
    {
        public TDT() : base("TDT", "TRANSPORT INFORMATION"){}

				[ElementInfo(0, "TRANSPORT STAGE CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E8051 { get; set; }
		[ElementInfo(1, "MEANS OF TRANSPORT JOURNEY IDENTIFIER", "Conditional", "", "", "" )]
public string E8028 { get; set; }
		[ElementInfo(2, "MODE OF TRANSPORT", "Conditional", "", "", "" )]
public C220 C220 { get; set; }
		[ElementInfo(3, "TRANSPORT MEANS", "Conditional", "", "", "" )]
public C001 C001 { get; set; }
		[ElementInfo(4, "CARRIER", "Conditional", "", "", "" )]
public C040 C040 { get; set; }
		[ElementInfo(5, "TRANSIT DIRECTION INDICATOR CODE", "Conditional", "", "", "" )]
public string E8101 { get; set; }
		[ElementInfo(6, "EXCESS TRANSPORTATION INFORMATION", "Conditional", "", "", "" )]
public C401 C401 { get; set; }
		[ElementInfo(7, "TRANSPORT IDENTIFICATION", "Conditional", "", "", "" )]
public C222 C222 { get; set; }
		[ElementInfo(8, "TRANSPORT MEANS OWNERSHIP INDICATOR CODE", "Conditional", "", "", "" )]
public string E8281 { get; set; }

		
    }
}