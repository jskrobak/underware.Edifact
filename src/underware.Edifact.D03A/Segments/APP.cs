using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class APP : Segment
    {
        public APP() : base("APP", "Applicability"){}

				[ElementInfo(0, "Applicability code qualifier", "C", "1", "an..3", "" )]
public string E9051 { get; set; }
		[ElementInfo(1, "APPLICABILITY TYPE", "C", "1", "", "" )]
public C973 C973 { get; set; }

		
    }
}