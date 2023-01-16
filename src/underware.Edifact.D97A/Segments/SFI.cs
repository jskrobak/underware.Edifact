using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class SFI : Segment
    {
        public SFI() : base("SFI", "Safety information"){}

				[ElementInfo(0, "Hierarchical id. number", "M", "1", "an..12", "" )]
public string E7164 { get; set; }
		[ElementInfo(1, "SAFETY SECTION", "C", "1", "", "" )]
public C814 C814 { get; set; }
		[ElementInfo(2, "ADDITIONAL SAFETY INFORMATION", "C", "1", "", "" )]
public C815 C815 { get; set; }
		[ElementInfo(3, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}