using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class PAC : Segment
    {
        public PAC() : base("PAC", "Package"){}

				[ElementInfo(0, "Number of packages", "C", "1", "n..8", "" )]
public string E7224 { get; set; }
		[ElementInfo(1, "PACKAGING DETAILS", "C", "1", "", "" )]
public C531 C531 { get; set; }
		[ElementInfo(2, "PACKAGE TYPE", "C", "1", "", "" )]
public C202 C202 { get; set; }
		[ElementInfo(3, "Code list qualifier", "C", "1", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(4, "Code list responsible agency, coded", "C", "1", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(5, "Type of packages", "C", "1", "an..35", "" )]
public string E7064 { get; set; }
		[ElementInfo(6, "PACKAGE TYPE IDENTIFICATION", "C", "1", "", "" )]
public C402 C402 { get; set; }
		[ElementInfo(7, "RETURNABLE PACKAGE DETAILS", "C", "1", "", "" )]
public C532 C532 { get; set; }

		
    }
}