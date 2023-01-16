using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95B.Composites
{
    public class C279
    {
				[ElementInfo(0, "Quantity difference", "M", "", "n..15", "" )]
public string E6064 { get; set; }
		[ElementInfo(1, "Quantity qualifier", "C", "", "an..3", "" )]
public string E6063 { get; set; }

    }
}