
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class PRV : Segment
    {
        public PRV() : base("PRV", "Proviso details"){}

				[ElementInfo(0, "Proviso code qualifier", "M", "1", "an..3", "" )]
public string E4071 { get; set; }
		[ElementInfo(1, "PROVISO TYPE", "C", "1", "", "" )]
public C971 C971 { get; set; }
		[ElementInfo(2, "PROVISO CALCULATION", "C", "1", "", "" )]
public C972 C972 { get; set; }

		
    }
}