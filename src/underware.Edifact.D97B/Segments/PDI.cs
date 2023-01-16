using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97B.Composites;

namespace underware.Edifact.D97B.Segments
{
    public class PDI : Segment
    {
        public PDI() : base("PDI", "Person demographic information"){}

				[ElementInfo(0, "Sex, coded", "C", "1", "an..3", "" )]
public string E3499 { get; set; }
		[ElementInfo(1, "MARITAL STATUS DETAILS", "C", "1", "", "" )]
public C085 C085 { get; set; }
		[ElementInfo(2, "RELIGION DETAILS", "C", "1", "", "" )]
public C101 C101 { get; set; }

		
    }
}