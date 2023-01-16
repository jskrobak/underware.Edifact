using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class PAI : Segment
    {
        public PAI() : base("PAI", "Payment instructions"){}

				[ElementInfo(0, "PAYMENT INSTRUCTION DETAILS", "M", "1", "", "" )]
public C534 C534 { get; set; }

		
    }
}