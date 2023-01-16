using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class ERP : Segment
    {
        public ERP() : base("ERP", "Error point details"){}

				[ElementInfo(0, "ERROR POINT DETAILS", "C", "1", "", "" )]
public C701 C701 { get; set; }
		[ElementInfo(1, "ERROR SEGMENT POINT DETAILS", "C", "1", "", "" )]
public C853 C853 { get; set; }

		
    }
}