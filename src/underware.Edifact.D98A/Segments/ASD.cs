using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class ASD : Segment
    {
        public ASD() : base("ASD", "Service details"){}

				[ElementInfo(0, "SERVICE DATE, TIME, LOCATION INFORMATION", "M", "9", "", "" )]
public E959 E959 { get; set; }

		
    }
}