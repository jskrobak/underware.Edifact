
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class ROD : Segment
    {
        public ROD() : base("ROD", "Risk object type"){}

				[ElementInfo(0, "RISK OBJECT TYPE", "C", "1", "", "" )]
public C851 C851 { get; set; }
		[ElementInfo(1, "RISK OBJECT SUB-TYPE", "C", "1", "", "" )]
public C852 C852 { get; set; }

		
    }
}