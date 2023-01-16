using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01C.Composites
{
    public class C174
    {
				[ElementInfo(0, "Measurement unit code", "M", "", "an..3", "" )]
public string E6411 { get; set; }
		[ElementInfo(1, "Measure", "C", "", "an..18", "" )]
public string E6314 { get; set; }
		[ElementInfo(2, "Range minimum quantity", "C", "", "n..18", "" )]
public string E6162 { get; set; }
		[ElementInfo(3, "Range maximum quantity", "C", "", "n..18", "" )]
public string E6152 { get; set; }
		[ElementInfo(4, "Significant digits quantity", "C", "", "n..2", "" )]
public string E6432 { get; set; }

    }
}