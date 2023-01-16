using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class PGI : Segment
    {
        public PGI() : base("PGI", "Product group information"){}

				[ElementInfo(0, "Product group type code", "M", "1", "an..3", "" )]
public string E5379 { get; set; }
		[ElementInfo(1, "PRODUCT GROUP", "C", "1", "", "" )]
public C288 C288 { get; set; }

		
    }
}