using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D99B.Composites
{
    public class E030
    {
				[ElementInfo(0, "Adjustment category code", "M", "", "an..3", "" )]
public string E9619 { get; set; }
		[ElementInfo(1, "Adjustment reason description code", "M", "", "an..3", "" )]
public string E4465 { get; set; }
		[ElementInfo(2, "Monetary amount value", "C", "", "n..35", "" )]
public string E5004 { get; set; }

    }
}