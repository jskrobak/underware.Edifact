using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class CED : Segment
    {
        public CED() : base("CED", "Computer environment details"){}

				[ElementInfo(0, "Computer environment details qualifier", "M", "1", "an..3", "" )]
public string E1501 { get; set; }
		[ElementInfo(1, "COMPUTER ENVIRONMENT IDENTIFICATION", "M", "1", "", "" )]
public C079 C079 { get; set; }
		[ElementInfo(2, "File generating command", "C", "1", "an..35", "" )]
public string E9448 { get; set; }

		
    }
}