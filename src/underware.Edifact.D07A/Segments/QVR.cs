using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class QVR : Segment
    {
        public QVR() : base("QVR", "QUANTITY VARIANCES"){}

				[ElementInfo(0, "QUANTITY DIFFERENCE INFORMATION", "Conditional", "", "", "" )]
public C279 C279 { get; set; }
		[ElementInfo(1, "DISCREPANCY NATURE IDENTIFICATION CODE", "Conditional", "", "", "" )]
public string E4221 { get; set; }
		[ElementInfo(2, "REASON FOR CHANGE", "Conditional", "", "", "" )]
public C960 C960 { get; set; }

		
    }
}