
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class EQD : Segment
    {
        public EQD() : base("EQD", "Equipment details"){}

				[ElementInfo(0, "Equipment type code qualifier", "M", "1", "an..3", "" )]
public string E8053 { get; set; }
		[ElementInfo(1, "EQUIPMENT IDENTIFICATION", "C", "1", "", "" )]
public C237 C237 { get; set; }
		[ElementInfo(2, "EQUIPMENT SIZE AND TYPE", "C", "1", "", "" )]
public C224 C224 { get; set; }
		[ElementInfo(3, "Equipment supplier code", "C", "1", "an..3", "" )]
public string E8077 { get; set; }
		[ElementInfo(4, "Equipment status code", "C", "1", "an..3", "" )]
public string E8249 { get; set; }
		[ElementInfo(5, "Full or empty indicator code", "C", "1", "an..3", "" )]
public string E8169 { get; set; }

		
    }
}