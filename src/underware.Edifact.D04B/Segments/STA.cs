using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class STA : Segment
    {
        public STA() : base("STA", "Statistics"){}

				[ElementInfo(0, "Statistic type code qualifier", "M", "1", "an..3", "" )]
public string E6331 { get; set; }
		[ElementInfo(1, "STATISTICAL DETAILS", "C", "1", "", "" )]
public C527 C527 { get; set; }

		
    }
}