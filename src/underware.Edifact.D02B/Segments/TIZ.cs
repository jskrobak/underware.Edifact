using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class TIZ : Segment
    {
        public TIZ() : base("TIZ", "Time zone information"){}

				[ElementInfo(0, "TIME ZONE", "M", "1", "", "" )]
public E034 E034 { get; set; }

		
    }
}