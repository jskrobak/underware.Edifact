using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class E958
    {
				[ElementInfo(0, "Quantity", "C", "", "n..15", "" )]
public string E6060 { get; set; }
		[ElementInfo(1, "Status, coded", "C", "", "an..3", "" )]
public string E4405 { get; set; }

    }
}