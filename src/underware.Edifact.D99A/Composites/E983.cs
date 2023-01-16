using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99A.Composites
{
    public class E983
    {
				[ElementInfo(0, "Rate/tariff class identification", "C", "", "an..9", "" )]
public string E5243 { get; set; }
		[ElementInfo(1, "Range minimum", "C", "", "n..18", "" )]
public string E6162 { get; set; }
		[ElementInfo(2, "Range maximum", "C", "", "n..18", "" )]
public string E6152 { get; set; }
		[ElementInfo(3, "Processing indicator, coded", "C", "", "an..3", "" )]
public string E7365 { get; set; }
		[ElementInfo(4, "Currency, coded", "C", "", "an..3", "" )]
public string E6345 { get; set; }

    }
}