using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class QTY : Segment
    {
        public QTY() : base("QTY", "QUANTITY"){}

				[ElementInfo(0, "QUANTITY DETAILS", "Mandatory", "", "", "" )]
public C186 C186 { get; set; }

		
    }
}