using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D07A.Composites
{
    public class C402
    {
				[ElementInfo(0, "Description format code", "Mandatory", "", "", "" )]
public string E7077 { get; set; }
		[ElementInfo(1, "Type of packages", "Mandatory", "", "", "" )]
public string E7064 { get; set; }
		[ElementInfo(2, "Item type identification code", "Conditional", "", "", "" )]
public string E7143 { get; set; }
		[ElementInfo(3, "Type of packages", "Conditional", "", "", "" )]
public string E7064_0 { get; set; }
		[ElementInfo(4, "Item type identification code", "Conditional", "", "", "" )]
public string E7143_0 { get; set; }

    }
}