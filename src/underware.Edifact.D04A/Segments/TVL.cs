using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class TVL : Segment
    {
        public TVL() : base("TVL", "Travel product information"){}

				[ElementInfo(0, "PRODUCT DATE AND TIME", "C", "1", "", "" )]
public E987 E987 { get; set; }
		[ElementInfo(1, "LOCATION", "C", "2", "", "" )]
public E975 E975 { get; set; }
		[ElementInfo(2, "COMPANY IDENTIFICATION", "C", "1", "", "" )]
public E988 E988 { get; set; }
		[ElementInfo(3, "PRODUCT IDENTIFICATION DETAILS", "C", "1", "", "" )]
public E989 E989 { get; set; }
		[ElementInfo(4, "SEQUENCE NUMBER DETAILS", "C", "1", "", "" )]
public E990 E990 { get; set; }
		[ElementInfo(5, "Line item identifier", "C", "1", "an..6", "" )]
public string E1082 { get; set; }
		[ElementInfo(6, "Processing indicator description code", "C", "1", "an..3", "" )]
public string E7365 { get; set; }

		
    }
}