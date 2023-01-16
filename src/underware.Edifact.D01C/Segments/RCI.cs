using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class RCI : Segment
    {
        public RCI() : base("RCI", "Reservation control information"){}

				[ElementInfo(0, "RESERVATION CONTROL INFORMATION", "C", "99", "", "" )]
public E979 E979 { get; set; }

		
    }
}