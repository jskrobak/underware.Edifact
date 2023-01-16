using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C213
    {
				[ElementInfo(0, "Package quantity", "C", "", "n..8", "" )]
public string E7224 { get; set; }
		[ElementInfo(1, "Package type description code", "C", "", "an..17", "" )]
public string E7065 { get; set; }
		[ElementInfo(2, "Code list identification code", "C", "", "an..17", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Code list responsible agency code", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(4, "Type of packages", "C", "", "an..35", "" )]
public string E7064 { get; set; }
		[ElementInfo(5, "Packaging related description code", "C", "", "an..3", "" )]
public string E7233 { get; set; }

    }
}