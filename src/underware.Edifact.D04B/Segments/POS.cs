using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class POS : Segment
    {
        public POS() : base("POS", "Point of sale information"){}

				[ElementInfo(0, "PARTY IDENTIFICATION", "C", "999", "", "" )]
public E032 E032 { get; set; }
		[ElementInfo(1, "LOCATION", "C", "999", "", "" )]
public E975 E975 { get; set; }

		
    }
}