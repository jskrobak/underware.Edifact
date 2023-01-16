using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class FNT : Segment
    {
        public FNT() : base("FNT", "Footnote"){}

				[ElementInfo(0, "FOOTNOTE IDENTIFICATION", "M", "1", "", "" )]
public C784 C784 { get; set; }
		[ElementInfo(1, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "" )]
public C082 C082 { get; set; }
		[ElementInfo(2, "Status, coded", "C", "1", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(3, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}