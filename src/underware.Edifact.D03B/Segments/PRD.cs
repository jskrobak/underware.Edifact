using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class PRD : Segment
    {
        public PRD() : base("PRD", "Product identification"){}

				[ElementInfo(0, "PRODUCT IDENTIFICATION DETAILS", "C", "9", "", "" )]
public E989 E989 { get; set; }
		[ElementInfo(1, "Party name", "C", "6", "an..35", "" )]
public string E3036 { get; set; }

		
    }
}