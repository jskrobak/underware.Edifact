using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class C280
    {
				[ElementInfo(0, "Measurement unit code", "M", "", "an..8", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Range minimum quantity", "C", "", "n..18", "" )]
public string E6162 { get; set; }
		[ElementInfo(2, "Range maximum quantity", "C", "", "n..18", "" )]
public string E6152 { get; set; }

    }
}