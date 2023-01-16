using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class DAM : Segment
    {
        public DAM() : base("DAM", "Damage"){}

				[ElementInfo(0, "Damage details code qualifier", "M", "1", "an..3", "" )]
public string E7493 { get; set; }
		[ElementInfo(1, "TYPE OF DAMAGE", "C", "1", "", "" )]
public C821 C821 { get; set; }
		[ElementInfo(2, "DAMAGE AREA", "C", "1", "", "" )]
public C822 C822 { get; set; }
		[ElementInfo(3, "DAMAGE SEVERITY", "C", "1", "", "" )]
public C825 C825 { get; set; }
		[ElementInfo(4, "ACTION", "C", "1", "", "" )]
public C826 C826 { get; set; }

		
    }
}