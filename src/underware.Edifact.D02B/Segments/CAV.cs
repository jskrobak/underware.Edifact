using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class CAV : Segment
    {
        public CAV() : base("CAV", "Characteristic value"){}

				[ElementInfo(0, "CHARACTERISTIC VALUE", "M", "1", "", "" )]
public C889 C889 { get; set; }

		
    }
}