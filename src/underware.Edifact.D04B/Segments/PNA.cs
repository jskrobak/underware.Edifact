using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class PNA : Segment
    {
        public PNA() : base("PNA", "Party identification"){}

				[ElementInfo(0, "Party function code qualifier", "M", "1", "an..3", "" )]
public string E3035 { get; set; }
		[ElementInfo(1, "IDENTIFICATION NUMBER", "C", "1", "", "" )]
public C206 C206 { get; set; }
		[ElementInfo(2, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "" )]
public C082 C082 { get; set; }
		[ElementInfo(3, "Name type code", "C", "1", "an..3", "" )]
public string E3403 { get; set; }
		[ElementInfo(4, "Name status code", "C", "1", "an..3", "" )]
public string E3397 { get; set; }
		[ElementInfo(5, "NAME COMPONENT DETAILS", "C", "1", "", "" )]
public C816 C816 { get; set; }
		[ElementInfo(6, "NAME COMPONENT DETAILS", "C", "1", "", "" )]
public C816 C816_0 { get; set; }
		[ElementInfo(7, "NAME COMPONENT DETAILS", "C", "1", "", "" )]
public C816 C816_1 { get; set; }
		[ElementInfo(8, "NAME COMPONENT DETAILS", "C", "1", "", "" )]
public C816 C816_2 { get; set; }
		[ElementInfo(9, "NAME COMPONENT DETAILS", "C", "1", "", "" )]
public C816 C816_3 { get; set; }
		[ElementInfo(10, "Action request/notification description code", "C", "1", "an..3", "" )]
public string E1229 { get; set; }

		
    }
}