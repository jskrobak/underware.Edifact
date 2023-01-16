using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98A.Composites;

namespace underware.Edifact.D98A.Segments
{
    public class SDT : Segment
    {
        public SDT() : base("SDT", "Selection details"){}

				[ElementInfo(0, "SELECTION DETAILS INFORMATION", "M", "99", "", "" )]
public E010 E010 { get; set; }

		
    }
}