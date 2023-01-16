using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class PRI : Segment
    {
        public PRI() : base("PRI", "PRICE DETAILS"){}

				[ElementInfo(0, "PRICE INFORMATION", "Conditional", "", "", "" )]
public C509 C509 { get; set; }
		[ElementInfo(1, "SUB-LINE ITEM PRICE CHANGE OPERATION CODE", "Conditional", "", "", "" )]
public string E5213 { get; set; }

		
    }
}