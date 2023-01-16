using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class COD : Segment
    {
        public COD() : base("COD", "Component details"){}

				[ElementInfo(0, "TYPE OF UNIT/COMPONENT", "C", "1", "", "" )]
public C823 C823 { get; set; }
		[ElementInfo(1, "COMPONENT MATERIAL", "C", "1", "", "" )]
public C824 C824 { get; set; }

		
    }
}