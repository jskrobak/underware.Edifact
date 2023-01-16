using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class GIN : Segment
    {
        public GIN() : base("GIN", "Goods identity number"){}

				[ElementInfo(0, "Identity number qualifier", "M", "1", "an..3", "" )]
public string E7405 { get; set; }
		[ElementInfo(1, "IDENTITY NUMBER RANGE", "M", "1", "", "" )]
public C208 C208 { get; set; }
		[ElementInfo(2, "IDENTITY NUMBER RANGE", "C", "1", "", "" )]
public C208 C208_0 { get; set; }
		[ElementInfo(3, "IDENTITY NUMBER RANGE", "C", "1", "", "" )]
public C208 C208_1 { get; set; }
		[ElementInfo(4, "IDENTITY NUMBER RANGE", "C", "1", "", "" )]
public C208 C208_2 { get; set; }
		[ElementInfo(5, "IDENTITY NUMBER RANGE", "C", "1", "", "" )]
public C208 C208_3 { get; set; }

		
    }
}