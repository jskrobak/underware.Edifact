using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class NUN : Segment
    {
        public NUN() : base("NUN", "Number of units"){}

				[ElementInfo(0, "NUMBER OF UNIT DETAILS", "M", "9", "", "" )]
public E523 E523 { get; set; }

		
    }
}