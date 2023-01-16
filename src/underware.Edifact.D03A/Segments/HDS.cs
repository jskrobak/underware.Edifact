using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class HDS : Segment
    {
        public HDS() : base("HDS", "Health diagnosis service and delivery"){}

				[ElementInfo(0, "DIAGNOSIS", "C", "1", "", "" )]
public E029 E029 { get; set; }
		[ElementInfo(1, "SERVICE", "C", "1", "", "" )]
public E021 E021 { get; set; }
		[ElementInfo(2, "DELIVERY PATTERN", "C", "1", "", "" )]
public E083 E083 { get; set; }

		
    }
}