using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class E016
    {
				[ElementInfo(0, "Insurance cover type code", "M", "", "an..3", "" )]
public string E4497 { get; set; }
		[ElementInfo(1, "Requirement designator code", "C", "", "an..3", "" )]
public string E7299 { get; set; }

    }
}