using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
{
    public class PCI : Segment
    {
        public PCI() : base("PCI", "Package identification"){}

				[ElementInfo(0, "Marking instructions, coded", "C", "1", "an..3", "" )]
public string E4233 { get; set; }
		[ElementInfo(1, "MARKS & LABELS", "C", "1", "", "" )]
public C210 C210 { get; set; }
		[ElementInfo(2, "Container/package status, coded", "C", "1", "an..3", "" )]
public string E8275 { get; set; }
		[ElementInfo(3, "TYPE OF MARKING", "C", "1", "", "" )]
public C827 C827 { get; set; }

		
    }
}