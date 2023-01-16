using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class DIM : Segment
    {
        public DIM() : base("DIM", "Dimensions"){}

				[ElementInfo(0, "Dimension qualifier", "M", "1", "an..3", "" )]
public string E6145 { get; set; }
		[ElementInfo(1, "DIMENSIONS", "M", "1", "", "" )]
public C211 C211 { get; set; }

		
    }
}