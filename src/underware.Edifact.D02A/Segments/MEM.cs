using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02A.Composites;

namespace underware.Edifact.D02A.Segments
{
    public class MEM : Segment
    {
        public MEM() : base("MEM", "Membership details"){}

				[ElementInfo(0, "Membership type code qualifier", "M", "1", "an..3", "" )]
public string E7449 { get; set; }
		[ElementInfo(1, "MEMBERSHIP CATEGORY", "C", "1", "", "" )]
public C942 C942 { get; set; }
		[ElementInfo(2, "MEMBERSHIP STATUS", "C", "1", "", "" )]
public C944 C944 { get; set; }
		[ElementInfo(3, "MEMBERSHIP LEVEL", "C", "1", "", "" )]
public C945 C945 { get; set; }
		[ElementInfo(4, "RATE/TARIFF CLASS", "C", "1", "", "" )]
public C203 C203 { get; set; }
		[ElementInfo(5, "REASON FOR CHANGE", "C", "1", "", "" )]
public C960 C960 { get; set; }

		
    }
}