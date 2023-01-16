using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C234
    {
				[ElementInfo(0, "United Nations Dangerous Goods (UNDG) identifier", "Conditional", "", "", "" )]
public string E7124 { get; set; }
		[ElementInfo(1, "Dangerous goods flashpoint description", "Conditional", "", "", "" )]
public string E7088 { get; set; }

    }
}