using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class EDT : Segment
    {
        public EDT() : base("EDT", "Editing details"){}

				[ElementInfo(0, "Edit field length measure", "C", "1", "n..3", "" )]
public string E6178 { get; set; }
		[ElementInfo(1, "Edit mask format identifier", "C", "1", "an..35", "" )]
public string E9026 { get; set; }
		[ElementInfo(2, "Edit mask representation code", "C", "1", "an..3", "" )]
public string E9031 { get; set; }
		[ElementInfo(3, "Free text format code", "C", "1", "an..3", "" )]
public string E4447 { get; set; }

		
    }
}