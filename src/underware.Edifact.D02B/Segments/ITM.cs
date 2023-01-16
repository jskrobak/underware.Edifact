using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class ITM : Segment
    {
        public ITM() : base("ITM", "Item number"){}

				[ElementInfo(0, "ITEM NUMBER IDENTIFICATION", "C", "99", "", "" )]
public E212 E212 { get; set; }

		
    }
}