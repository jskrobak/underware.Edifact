using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E994
    {
				[ElementInfo(0, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(1, "Number of units", "C", "", "n..15", "" )]
public string E6350 { get; set; }

    }
}