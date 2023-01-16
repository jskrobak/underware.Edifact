
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class BLI : Segment
    {
        public BLI() : base("BLI", "Billable information"){}

				[ElementInfo(0, "Monetary amount", "C", "3", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(1, "DIAGNOSIS", "C", "9", "", "" )]
public E029 E029 { get; set; }
		[ElementInfo(2, "DATE/TIME/PERIOD", "C", "9", "", "" )]
public E507 E507 { get; set; }
		[ElementInfo(3, "Object identifier", "C", "5", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(4, "Yes or no indicator code", "C", "3", "an..3", "" )]
public string E9607 { get; set; }
		[ElementInfo(5, "RELATED CAUSE", "C", "9", "", "" )]
public E028 E028 { get; set; }

		
    }
}