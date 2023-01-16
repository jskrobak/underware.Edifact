using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D98A.Composites
{
    public class E976
    {
				[ElementInfo(0, "Country, coded", "C", "", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(1, "Currency, coded", "C", "", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(2, "Language, coded", "C", "", "an..3", "" )]
public string E3453 { get; set; }

    }
}