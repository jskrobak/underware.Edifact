using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class UNS : Segment
    {
        public UNS() : base("UNS", "SECTION CONTROL"){}

				[ElementInfo(0, "SECTION IDENTIFICATION", "Mandatory", "", "", "" )]
public string E0081 { get; set; }

		
    }
}