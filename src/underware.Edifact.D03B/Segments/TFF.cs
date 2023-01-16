using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class TFF : Segment
    {
        public TFF() : base("TFF", "Tariff information"){}

				[ElementInfo(0, "TARIFF INFORMATION", "C", "99", "", "" )]
public E982 E982 { get; set; }
		[ElementInfo(1, "RATE INFORMATION", "C", "99", "", "" )]
public E983 E983 { get; set; }
		[ElementInfo(2, "ASSOCIATED CHARGES INFORMATION", "C", "99", "", "" )]
public E984 E984 { get; set; }

		
    }
}