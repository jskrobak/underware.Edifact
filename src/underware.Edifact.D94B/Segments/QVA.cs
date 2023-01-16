using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94B.Composites;

namespace underware.Edifact.D94B.Segments
{
    public class QVA : Segment
    {
        public QVA() : base("QVA", "Quantity variances"){}

				[ElementInfo(0, "QUANTITY DIFFERENCE INFORMATION", "C", "1", "", "" )]
public C279 C279 { get; set; }
		[ElementInfo(1, "Discrepancy, coded", "C", "1", "an..3", "" )]
public string E4221 { get; set; }
		[ElementInfo(2, "REASON FOR CHANGE", "C", "1", "", "" )]
public C262 C262 { get; set; }

		
    }
}