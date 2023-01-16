using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
{
    public class SGU : Segment
    {
        public SGU() : base("SGU", "Segment usage details"){}

				[ElementInfo(0, "Segment tag", "M", "1", "an..3", "" )]
public string E9166 { get; set; }
		[ElementInfo(1, "Requirement designator, coded", "C", "1", "an..3", "" )]
public string E7299 { get; set; }
		[ElementInfo(2, "Maximum number of occurrences", "C", "1", "n..7", "" )]
public string E6176 { get; set; }
		[ElementInfo(3, "Level number", "C", "1", "n1", "" )]
public string E7168 { get; set; }
		[ElementInfo(4, "Sequence number", "C", "1", "an..6", "" )]
public string E1050 { get; set; }
		[ElementInfo(5, "Message section, coded", "C", "1", "an..3", "" )]
public string E1049 { get; set; }
		[ElementInfo(6, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}