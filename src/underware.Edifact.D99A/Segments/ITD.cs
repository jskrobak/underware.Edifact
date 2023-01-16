using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class ITD : Segment
    {
        public ITD() : base("ITD", "Information type data"){}

				[ElementInfo(0, "Information category, coded", "C", "1", "an..3", "" )]
public string E9601 { get; set; }
		[ElementInfo(1, "Language, coded", "C", "1", "an..3", "" )]
public string E3453 { get; set; }
		[ElementInfo(2, "Information detail identification", "C", "10", "an..17", "" )]
public string E9603 { get; set; }
		[ElementInfo(3, "Data format, coded", "C", "1", "an..3", "" )]
public string E1503 { get; set; }

		
    }
}