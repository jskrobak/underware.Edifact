using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class LKP : Segment
    {
        public LKP() : base("LKP", "Level indication"){}

				[ElementInfo(0, "POSITION IDENTIFICATION", "M", "1", "", "" )]
public E778 E778 { get; set; }

		
    }
}