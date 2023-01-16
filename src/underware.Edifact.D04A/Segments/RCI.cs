using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class RCI : Segment
    {
        public RCI() : base("RCI", "Reservation control information"){}

				[ElementInfo(0, "RESERVATION CONTROL INFORMATION", "C", "99", "", "" )]
public E979 E979 { get; set; }

		
    }
}