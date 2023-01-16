using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class FTX : Segment
    {
        public FTX() : base("FTX", "Free text"){}

				[ElementInfo(0, "Text subject qualifier", "M", "1", "an..3", "" )]
public string E4451 { get; set; }
		[ElementInfo(1, "Text function, coded", "C", "1", "an..3", "" )]
public string E4453 { get; set; }
		[ElementInfo(2, "TEXT REFERENCE", "C", "1", "", "" )]
public C107 C107 { get; set; }
		[ElementInfo(3, "TEXT LITERAL", "C", "1", "", "" )]
public C108 C108 { get; set; }
		[ElementInfo(4, "Language, coded", "C", "1", "an..3", "" )]
public string E3453 { get; set; }

		
    }
}