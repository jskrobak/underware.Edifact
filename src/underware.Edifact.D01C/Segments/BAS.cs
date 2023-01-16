using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class BAS : Segment
    {
        public BAS() : base("BAS", "Basis"){}

				[ElementInfo(0, "Basis code qualifier", "M", "1", "an..3", "" )]
public string E9045 { get; set; }
		[ElementInfo(1, "BASIS TYPE", "M", "1", "", "" )]
public C974 C974 { get; set; }

		
    }
}