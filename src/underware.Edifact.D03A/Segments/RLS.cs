using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class RLS : Segment
    {
        public RLS() : base("RLS", "Relationship"){}

				[ElementInfo(0, "Relationship type code qualifier", "M", "1", "an..3", "" )]
public string E9141 { get; set; }
		[ElementInfo(1, "RELATIONSHIP", "C", "1", "", "" )]
public E941 E941 { get; set; }

		
    }
}