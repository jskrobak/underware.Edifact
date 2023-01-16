using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class QTI : Segment
    {
        public QTI() : base("QTI", "Quantity"){}

				[ElementInfo(0, "QUANTITY DETAILS", "M", "9", "", "" )]
public E035 E035 { get; set; }

		
    }
}