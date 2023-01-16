using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class CPI : Segment
    {
        public CPI() : base("CPI", "Charge payment instructions"){}

				[ElementInfo(0, "CHARGE CATEGORY", "C", "1", "", "" )]
public C229 C229 { get; set; }
		[ElementInfo(1, "METHOD OF PAYMENT", "C", "1", "", "" )]
public C231 C231 { get; set; }
		[ElementInfo(2, "Prepaid/collect indicator, coded", "C", "1", "an..3", "" )]
public string E4237 { get; set; }

		
    }
}