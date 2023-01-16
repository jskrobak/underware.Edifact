using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04B.Composites
{
    public class E977
    {
				[ElementInfo(0, "Payment method code", "C", "", "an..4", "" )]
public string E4467 { get; set; }
		[ElementInfo(1, "Payment purpose code", "C", "", "an..4", "" )]
public string E4469 { get; set; }
		[ElementInfo(2, "Service type code", "C", "", "an..3", "" )]
public string E5267 { get; set; }
		[ElementInfo(3, "Monetary amount", "C", "", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(4, "Currency identification code", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(5, "Reference identifier", "C", "", "an..70", "" )]
public string E1154 { get; set; }
		[ElementInfo(6, "Date", "C", "", "an..14", "" )]
public string E2000 { get; set; }
		[ElementInfo(7, "Location name code", "C", "", "an..35", "" )]
public string E3225 { get; set; }

    }
}