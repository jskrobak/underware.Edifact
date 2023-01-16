using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class EQD : Segment
    {
        public EQD() : base("EQD", "Equipment details"){}

				[ElementInfo(0, "Equipment qualifier", "M", "1", "an..3", "" )]
public string E8053 { get; set; }
		[ElementInfo(1, "EQUIPMENT IDENTIFICATION", "C", "1", "", "" )]
public C237 C237 { get; set; }
		[ElementInfo(2, "EQUIPMENT SIZE AND TYPE", "C", "1", "", "" )]
public C224 C224 { get; set; }
		[ElementInfo(3, "Equipment supplier, coded", "C", "1", "an..3", "" )]
public string E8077 { get; set; }
		[ElementInfo(4, "Equipment status, coded", "C", "1", "an..3", "" )]
public string E8249 { get; set; }
		[ElementInfo(5, "Full/empty indicator, coded", "C", "1", "an..3", "" )]
public string E8169 { get; set; }

		
    }
}