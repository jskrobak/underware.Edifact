using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C280
    {
				[ElementInfo(0, "Measure unit qualifier", "M", "", "an..3", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Range minimum", "C", "", "n..18", "" )]
public string E6162 { get; set; }
		[ElementInfo(2, "Range maximum", "C", "", "n..18", "" )]
public string E6152 { get; set; }

    }
}