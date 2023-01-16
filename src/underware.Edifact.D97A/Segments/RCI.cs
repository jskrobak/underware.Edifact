using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class RCI : Segment
    {
        public RCI() : base("RCI", "Reservation control information"){}

				[ElementInfo(0, "RESERVATION CONTROL IDENTIFICATION", "C", "99", "", "" )]
public E979 E979 { get; set; }

		
    }
}