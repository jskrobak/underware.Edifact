using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class BCD : Segment
    {
        public BCD() : base("BCD", "Benefit and coverage detail"){}

				[ElementInfo(0, "Service type code", "M", "1", "an..3", "" )]
public string E5267 { get; set; }
		[ElementInfo(1, "Benefit and coverage code", "M", "1", "an..3", "" )]
public string E7517 { get; set; }
		[ElementInfo(2, "Benefit coverage constituents code", "C", "1", "an..3", "" )]
public string E3507 { get; set; }
		[ElementInfo(3, "Period type code", "C", "1", "an..3", "" )]
public string E2151 { get; set; }
		[ElementInfo(4, "MONETARY AMOUNT", "C", "1", "", "" )]
public E017 E017 { get; set; }
		[ElementInfo(5, "Percentage", "C", "1", "n..10", "" )]
public string E5482 { get; set; }
		[ElementInfo(6, "Quantity type code qualifier", "C", "1", "an..3", "" )]
public string E6063 { get; set; }
		[ElementInfo(7, "Quantity", "C", "1", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(8, "Yes or no indicator code", "C", "2", "an..3", "" )]
public string E9607 { get; set; }
		[ElementInfo(9, "Insurance cover type code", "C", "1", "an..3", "" )]
public string E4497 { get; set; }
		[ElementInfo(10, "Free text", "C", "1", "an..512", "" )]
public string E4440 { get; set; }

		
    }
}