using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class PRO : Segment
    {
        public PRO() : base("PRO", "Promotions"){}

				[ElementInfo(0, "PROMOTION DETAILS", "M", "20", "", "" )]
public E019 E019 { get; set; }

		
    }
}