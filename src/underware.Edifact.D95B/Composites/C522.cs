using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D95B.Composites
{
    public class C522
    {
				[ElementInfo(0, "Instruction qualifier", "M", "", "an..3", "" )]
public string E4403 { get; set; }
		[ElementInfo(1, "Instruction, coded", "C", "", "an..3", "" )]
public string E4401 { get; set; }
		[ElementInfo(2, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(3, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(4, "Instruction", "C", "", "an..35", "" )]
public string E4400 { get; set; }

    }
}