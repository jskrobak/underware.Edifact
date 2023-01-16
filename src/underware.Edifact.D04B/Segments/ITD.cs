using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class ITD : Segment
    {
        public ITD() : base("ITD", "Information type data"){}

				[ElementInfo(0, "Information category code", "C", "1", "an..3", "" )]
public string E9601 { get; set; }
		[ElementInfo(1, "Language name code", "C", "1", "an..3", "" )]
public string E3453 { get; set; }
		[ElementInfo(2, "Status description code", "C", "10", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(3, "Data format description code", "C", "1", "an..3", "" )]
public string E1503 { get; set; }

		
    }
}