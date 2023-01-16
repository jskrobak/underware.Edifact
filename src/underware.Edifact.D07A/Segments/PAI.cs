using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class PAI : Segment
    {
        public PAI() : base("PAI", "PAYMENT INSTRUCTIONS"){}

				[ElementInfo(0, "PAYMENT INSTRUCTION DETAILS", "Mandatory", "", "", "" )]
public C534 C534 { get; set; }

		
    }
}