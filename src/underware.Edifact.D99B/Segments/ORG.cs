using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class ORG : Segment
    {
        public ORG() : base("ORG", "Originator of request details"){}

				[ElementInfo(0, "DELIVERING SYSTEM DETAILS", "C", "1", "", "" )]
public E973 E973 { get; set; }
		[ElementInfo(1, "ORIGINATOR IDENTIFICATION DETAILS", "C", "1", "", "" )]
public E974 E974 { get; set; }
		[ElementInfo(2, "LOCATION", "C", "1", "", "" )]
public E975 E975 { get; set; }
		[ElementInfo(3, "Party name", "C", "1", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(4, "Originator type, coded", "C", "1", "an..3", "" )]
public string E3457 { get; set; }
		[ElementInfo(5, "ORIGINATOR DETAILS", "C", "1", "", "" )]
public E976 E976 { get; set; }
		[ElementInfo(6, "Originator's authority identification", "C", "1", "an..9", "" )]
public string E3503 { get; set; }

		
    }
}