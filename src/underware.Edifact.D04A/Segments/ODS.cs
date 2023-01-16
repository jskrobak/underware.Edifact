using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class ODS : Segment
    {
        public ODS() : base("ODS", "Additional product details"){}

				[ElementInfo(0, "Data code qualifier", "M", "1", "an..3", "" )]
public string E9605 { get; set; }
		[ElementInfo(1, "PRODUCT DATA INFORMATION", "M", "999", "", "" )]
public E015 E015 { get; set; }

		
    }
}