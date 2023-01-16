using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class IND : Segment
    {
        public IND() : base("IND", "Index details"){}

				[ElementInfo(0, "INDEX IDENTIFICATION", "C", "1", "", "" )]
public C545 C545 { get; set; }
		[ElementInfo(1, "INDEX VALUE", "C", "1", "", "" )]
public C546 C546 { get; set; }

		
    }
}