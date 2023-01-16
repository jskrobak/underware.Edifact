using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class PCI : Segment
    {
        public PCI() : base("PCI", "PACKAGE IDENTIFICATION"){}

				[ElementInfo(0, "MARKING INSTRUCTIONS CODE", "Conditional", "", "", "" )]
public string E4233 { get; set; }
		[ElementInfo(1, "MARKS &amp; LABELS", "Conditional", "", "", "" )]
public C210 C210 { get; set; }
		[ElementInfo(2, "FULL OR EMPTY INDICATOR CODE", "Conditional", "", "", "" )]
public string E8169 { get; set; }
		[ElementInfo(3, "TYPE OF MARKING", "Conditional", "", "", "" )]
public C827 C827 { get; set; }

		
    }
}