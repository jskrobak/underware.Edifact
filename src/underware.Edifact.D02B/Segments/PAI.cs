using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class PAI : Segment
    {
        public PAI() : base("PAI", "Payment instructions"){}

				[ElementInfo(0, "PAYMENT INSTRUCTION DETAILS", "M", "1", "", "" )]
public C534 C534 { get; set; }

		
    }
}