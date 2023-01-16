using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class CNY : Segment
    {
        public CNY() : base("CNY", "Country information"){}

				[ElementInfo(0, "Country name code", "M", "1", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(1, "DATE AND TIME INFORMATION", "C", "2", "", "" )]
public E013 E013 { get; set; }
		[ElementInfo(2, "Time variation quantity", "C", "2", "n..3", "" )]
public string E2031 { get; set; }
		[ElementInfo(3, "Currency identification code", "C", "1", "an..3", "" )]
public string E6345 { get; set; }
		[ElementInfo(4, "Language name code", "C", "9", "an..3", "" )]
public string E3453 { get; set; }

		
    }
}