using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class ODI : Segment
    {
        public ODI() : base("ODI", "Origin and destination details"){}

				[ElementInfo(0, "Place/location identification", "C", "2", "an..25", "" )]
public string E3225 { get; set; }

		
    }
}