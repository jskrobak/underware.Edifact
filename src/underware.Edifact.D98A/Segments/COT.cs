using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class COT : Segment
    {
        public COT() : base("COT", "Contribution details"){}

				[ElementInfo(0, "Contribution qualifier", "M", "1", "an..3", "" )]
public string E5047 { get; set; }
		[ElementInfo(1, "CONTRIBUTION TYPE", "C", "1", "", "" )]
public C953 C953 { get; set; }
		[ElementInfo(2, "INSTRUCTION", "C", "1", "", "" )]
public C522 C522 { get; set; }
		[ElementInfo(3, "RATE/TARIFF CLASS", "C", "1", "", "" )]
public C203 C203 { get; set; }

		
    }
}