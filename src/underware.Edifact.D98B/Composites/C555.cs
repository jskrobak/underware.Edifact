using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C555
    {
				[ElementInfo(0, "Status, coded", "M", "", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(1, "Code list qualifier", "C", "", "an..3", "" )]
public string E1131 { get; set; }
		[ElementInfo(2, "Code list responsible agency, coded", "C", "", "an..3", "" )]
public string E3055 { get; set; }
		[ElementInfo(3, "Status", "C", "", "an..35", "" )]
public string E4404 { get; set; }

    }
}