using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class NAM : Segment
    {
        public NAM() : base("NAM", "Party name"){}

				[ElementInfo(0, "Party qualifier", "M", "1", "an..3", "" )]
public string E3035 { get; set; }
		[ElementInfo(1, "IDENTIFICATION NUMBER", "C", "1", "", "" )]
public E206 E206 { get; set; }
		[ElementInfo(2, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "" )]
public E082 E082 { get; set; }
		[ElementInfo(3, "Name type, coded", "C", "1", "an..3", "" )]
public string E3403 { get; set; }
		[ElementInfo(4, "Name status, coded", "C", "1", "an..3", "" )]
public string E3397 { get; set; }
		[ElementInfo(5, "NAME COMPONENT DETAILS", "C", "5", "", "" )]
public E816 E816 { get; set; }

		
    }
}