using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class NUN : Segment
    {
        public NUN() : base("NUN", "Number of units"){}

				[ElementInfo(0, "NUMBER OF UNIT DETAILS", "M", "9", "", "" )]
public E523 E523 { get; set; }

		
    }
}