using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E975
    {
				[ElementInfo(0, "Place/location identification", "C", "", "an..25", "" )]
public string E3225 { get; set; }
		[ElementInfo(1, "Place/location", "C", "", "an..70", "" )]
public string E3224 { get; set; }

    }
}