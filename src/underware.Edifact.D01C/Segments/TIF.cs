using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class TIF : Segment
    {
        public TIF() : base("TIF", "Traveller information"){}

				[ElementInfo(0, "TRAVELLER SURNAME AND RELATED INFORMATION", "M", "1", "", "" )]
public E985 E985 { get; set; }
		[ElementInfo(1, "TRAVELLER DETAILS", "C", "99", "", "" )]
public E986 E986 { get; set; }

		
    }
}