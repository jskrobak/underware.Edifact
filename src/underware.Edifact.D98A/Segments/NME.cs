using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class NME : Segment
    {
        public NME() : base("NME", "Name"){}

				[ElementInfo(0, "NAME INFORMATION", "M", "9", "", "" )]
public E012 E012 { get; set; }

		
    }
}