using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
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
		[ElementInfo(3, "PACKAGE TYPE IDENTIFICATION", "C", "1", "", "" )]
public C402 C402 { get; set; }
		[ElementInfo(4, "RETURNABLE PACKAGE DETAILS", "C", "1", "", "" )]
public C532 C532 { get; set; }

		
    }
}