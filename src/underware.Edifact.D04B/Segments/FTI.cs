using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class FTI : Segment
    {
        public FTI() : base("FTI", "Frequent traveller information"){}

				[ElementInfo(0, "FREQUENT TRAVELLER IDENTIFICATION", "M", "9", "", "" )]
public E970 E970 { get; set; }

		
    }
}