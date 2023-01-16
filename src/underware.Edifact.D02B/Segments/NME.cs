using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class NME : Segment
    {
        public NME() : base("NME", "Name"){}

				[ElementInfo(0, "NAME INFORMATION", "M", "9", "", "" )]
public E012 E012 { get; set; }

		
    }
}