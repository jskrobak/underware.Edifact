using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class PAS : Segment
    {
        public PAS() : base("PAS", "Attendance"){}

				[ElementInfo(0, "Attendance qualifier", "M", "1", "an..3", "" )]
public string E9443 { get; set; }
		[ElementInfo(1, "ATTENDEE CATEGORY", "C", "1", "", "" )]
public C839 C839 { get; set; }
		[ElementInfo(2, "ATTENDANCE ADMISSION DETAILS", "C", "1", "", "" )]
public C840 C840 { get; set; }
		[ElementInfo(3, "ATTENDANCE DISCHARGE DETAILS", "C", "1", "", "" )]
public C841 C841 { get; set; }

		
    }
}