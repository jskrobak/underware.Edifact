using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96B.Composites;

namespace underware.Edifact.D96B.Segments
{
    public class ATT : Segment
    {
        public ATT() : base("ATT", "Attribute"){}

				[ElementInfo(0, "Attribute function qualifier", "M", "1", "an..3", "" )]
public string E9017 { get; set; }
		[ElementInfo(1, "ATTRIBUTE TYPE", "C", "1", "", "" )]
public C955 C955 { get; set; }
		[ElementInfo(2, "ATTRIBUTE DETAILS", "C", "1", "", "" )]
public C956 C956 { get; set; }

		
    }
}