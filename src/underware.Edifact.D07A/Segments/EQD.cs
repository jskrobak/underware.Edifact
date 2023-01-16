using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class EQD : Segment
    {
        public EQD() : base("EQD", "EQUIPMENT DETAILS"){}

				[ElementInfo(0, "EQUIPMENT TYPE CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E8053 { get; set; }
		[ElementInfo(1, "EQUIPMENT IDENTIFICATION", "Conditional", "", "", "" )]
public C237 C237 { get; set; }
		[ElementInfo(2, "EQUIPMENT SIZE AND TYPE", "Conditional", "", "", "" )]
public C224 C224 { get; set; }
		[ElementInfo(3, "EQUIPMENT SUPPLIER CODE", "Conditional", "", "", "" )]
public string E8077 { get; set; }
		[ElementInfo(4, "EQUIPMENT STATUS CODE", "Conditional", "", "", "" )]
public string E8249 { get; set; }
		[ElementInfo(5, "FULL OR EMPTY INDICATOR CODE", "Conditional", "", "", "" )]
public string E8169 { get; set; }
		[ElementInfo(6, "MARKING INSTRUCTIONS CODE", "Conditional", "", "", "" )]
public string E4233 { get; set; }

		
    }
}