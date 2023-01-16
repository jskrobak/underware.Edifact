using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class PAC : Segment
    {
        public PAC() : base("PAC", "PACKAGE"){}

				[ElementInfo(0, "PACKAGE QUANTITY", "Conditional", "", "", "" )]
public string E7224 { get; set; }
		[ElementInfo(1, "PACKAGING DETAILS", "Conditional", "", "", "" )]
public C531 C531 { get; set; }
		[ElementInfo(2, "PACKAGE TYPE", "Conditional", "", "", "" )]
public C202 C202 { get; set; }
		[ElementInfo(3, "PACKAGE TYPE IDENTIFICATION", "Conditional", "", "", "" )]
public C402 C402 { get; set; }
		[ElementInfo(4, "RETURNABLE PACKAGE DETAILS", "Conditional", "", "", "" )]
public C532 C532 { get; set; }

		
    }
}