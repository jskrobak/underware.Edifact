using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95A.Composites;

namespace underware.Edifact.D95A.Segments
{
    public class GID : Segment
    {
        public GID() : base("GID", "Goods item details"){}

				[ElementInfo(0, "Goods item number", "C", "1", "n..5", "" )]
public string E1496 { get; set; }
		[ElementInfo(1, "NUMBER AND TYPE OF PACKAGES", "C", "1", "", "" )]
public C213 C213 { get; set; }
		[ElementInfo(2, "NUMBER AND TYPE OF PACKAGES", "C", "1", "", "" )]
public C213 C213_0 { get; set; }
		[ElementInfo(3, "NUMBER AND TYPE OF PACKAGES", "C", "1", "", "" )]
public C213 C213_1 { get; set; }

		
    }
}