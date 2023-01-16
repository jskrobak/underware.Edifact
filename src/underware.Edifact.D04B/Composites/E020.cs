using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class E020
    {
				[ElementInfo(0, "Duty or tax or fee type name code", "M", "", "an..3", "" )]
public string E5153 { get; set; }
		[ElementInfo(1, "Monetary amount", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(2, "Duty or tax or fee rate", "C", "", "an..17", "" )]
public string E5278 { get; set; }

    }
}