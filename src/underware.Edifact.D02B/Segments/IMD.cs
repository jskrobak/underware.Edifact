using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class IMD : Segment
    {
        public IMD() : base("IMD", "Item description"){}

				[ElementInfo(0, "Description format code", "C", "1", "an..3", "" )]
public string E7077 { get; set; }
		[ElementInfo(1, "ITEM CHARACTERISTIC", "C", "1", "", "" )]
public C272 C272 { get; set; }
		[ElementInfo(2, "ITEM DESCRIPTION", "C", "1", "", "" )]
public C273 C273 { get; set; }
		[ElementInfo(3, "Surface or layer code", "C", "1", "an..3", "" )]
public string E7383 { get; set; }

		
    }
}