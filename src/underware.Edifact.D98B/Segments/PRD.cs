using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class PRD : Segment
    {
        public PRD() : base("PRD", "Product identification"){}

				[ElementInfo(0, "PRODUCT IDENTIFICATION DETAILS", "C", "9", "", "" )]
public E989 E989 { get; set; }

		
    }
}