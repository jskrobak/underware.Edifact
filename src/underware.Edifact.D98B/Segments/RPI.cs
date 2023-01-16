using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class RPI : Segment
    {
        public RPI() : base("RPI", "Quantity and action details"){}

				[ElementInfo(0, "QUANTITY AND ACTION DETAILS", "M", "9", "", "" )]
public E958 E958 { get; set; }

		
    }
}