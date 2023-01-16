using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class ERP : Segment
    {
        public ERP() : base("ERP", "Error point details"){}

				[ElementInfo(0, "ERROR POINT DETAILS", "M", "1", "", "" )]
public C701 C701 { get; set; }

		
    }
}