using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class CRI : Segment
    {
        public CRI() : base("CRI", "Consumer reference information"){}

				[ElementInfo(0, "CONSUMER REFERENCE IDENTIFICATION", "M", "20", "", "" )]
public E967 E967 { get; set; }

		
    }
}