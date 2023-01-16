using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class VEH : Segment
    {
        public VEH() : base("VEH", "Vehicle"){}

				[ElementInfo(0, "Equipment qualifier", "C", "1", "an..3", "" )]
public string E8053 { get; set; }
		[ElementInfo(1, "VEHICLE INFORMATION", "C", "1", "", "" )]
public E991 E991 { get; set; }
		[ElementInfo(2, "DIMENSIONS", "C", "1", "", "" )]
public E211 E211 { get; set; }
		[ElementInfo(3, "Measurement value", "C", "1", "an..18", "" )]
public string E6314 { get; set; }
		[ElementInfo(4, "POSITION", "C", "1", "", "" )]
public E992 E992 { get; set; }

		
    }
}