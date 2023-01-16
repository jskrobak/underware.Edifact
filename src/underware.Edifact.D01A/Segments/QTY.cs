using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class QTY : Segment
    {
        public QTY() : base("QTY", "Quantity") { }

        [ElementInfo(0, "QUANTITY DETAILS", "M", "1", "", "")]
        public C186 C186 { get; set; }


    }
}