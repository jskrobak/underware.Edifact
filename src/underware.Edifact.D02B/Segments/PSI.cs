using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class PSI : Segment
    {
        public PSI() : base("PSI", "Service information"){}

				[ElementInfo(0, "Object identifier", "M", "4", "an..35", "" )]
public string E7402 { get; set; }
		[ElementInfo(1, "DATE/TIME/PERIOD", "C", "5", "", "" )]
public E507 E507 { get; set; }
		[ElementInfo(2, "SERVICE", "C", "1", "", "" )]
public E021 E021 { get; set; }
		[ElementInfo(3, "Quantity", "C", "2", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(4, "Monetary amount", "C", "5", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(5, "Index text", "C", "4", "an..35", "" )]
public string E5030 { get; set; }
		[ElementInfo(6, "Facility type description code", "C", "1", "an..3", "" )]
public string E9039 { get; set; }
		[ElementInfo(7, "Service type code", "C", "1", "an..3", "" )]
public string E5267 { get; set; }
		[ElementInfo(8, "Special condition code", "C", "9", "an..3", "" )]
public string E4183 { get; set; }
		[ElementInfo(9, "SUPPORTING EVIDENCE", "C", "1", "", "" )]
public E024 E024 { get; set; }

		
    }
}