using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98B.Composites
{
    public class C817
    {
				[ElementInfo(0, "Address purpose, coded", "C", "", "an..3", "" )]
public string E3299 { get; set; }
		[ElementInfo(1, "Address type, coded", "C", "", "an..3", "" )]
public string E3131 { get; set; }
		[ElementInfo(2, "Address status, coded", "C", "", "an..3", "" )]
public string E3475 { get; set; }

    }
}