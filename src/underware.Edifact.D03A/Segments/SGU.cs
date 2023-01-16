using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class SGU : Segment
    {
        public SGU() : base("SGU", "Segment usage details"){}

				[ElementInfo(0, "Segment tag identifier", "M", "1", "an..3", "" )]
public string E9166 { get; set; }
		[ElementInfo(1, "Requirement designator code", "C", "1", "an..3", "" )]
public string E7299 { get; set; }
		[ElementInfo(2, "Occurrences maximum number", "C", "1", "n..7", "" )]
public string E6176 { get; set; }
		[ElementInfo(3, "Level number", "C", "1", "n..3", "" )]
public string E7168 { get; set; }
		[ElementInfo(4, "Sequence position identifier", "C", "1", "an..10", "" )]
public string E1050 { get; set; }
		[ElementInfo(5, "Message section code", "C", "1", "an..3", "" )]
public string E1049 { get; set; }
		[ElementInfo(6, "Maintenance operation code", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}