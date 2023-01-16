using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class HDR : Segment
    {
        public HDR() : base("HDR", "Header information"){}

				[ElementInfo(0, "Status description code", "M", "1", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(1, "DATE AND TIME INFORMATION", "M", "4", "", "" )]
public E013 E013 { get; set; }
		[ElementInfo(2, "Reference identifier", "C", "1", "an..70", "" )]
public string E1154 { get; set; }
		[ElementInfo(3, "Free text", "C", "1", "an..512", "" )]
public string E4440 { get; set; }
		[ElementInfo(4, "Product identifier", "C", "2", "an..35", "" )]
public string E7135 { get; set; }
		[ElementInfo(5, "Language name code", "C", "1", "an..3", "" )]
public string E3453 { get; set; }

		
    }
}