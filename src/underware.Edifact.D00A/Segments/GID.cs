
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
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
		[ElementInfo(4, "NUMBER AND TYPE OF PACKAGES", "C", "1", "", "" )]
public C213 C213_2 { get; set; }
		[ElementInfo(5, "NUMBER AND TYPE OF PACKAGES", "C", "1", "", "" )]
public C213 C213_3 { get; set; }

		
    }
}