using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
{
    public class SPS : Segment
    {
        public SPS() : base("SPS", "Sampling parameters for summary statistics"){}

				[ElementInfo(0, "FREQUENCY DETAILS", "C", "1", "", "" )]
public C526 C526 { get; set; }
		[ElementInfo(1, "Confidence limit", "C", "1", "n..6", "" )]
public string E6074 { get; set; }
		[ElementInfo(2, "SIZE DETAILS", "C", "1", "", "" )]
public C512 C512 { get; set; }
		[ElementInfo(3, "SIZE DETAILS", "C", "1", "", "" )]
public C512 C512_0 { get; set; }
		[ElementInfo(4, "SIZE DETAILS", "C", "1", "", "" )]
public C512 C512_1 { get; set; }
		[ElementInfo(5, "SIZE DETAILS", "C", "1", "", "" )]
public C512 C512_2 { get; set; }
		[ElementInfo(6, "SIZE DETAILS", "C", "1", "", "" )]
public C512 C512_3 { get; set; }

		
    }
}