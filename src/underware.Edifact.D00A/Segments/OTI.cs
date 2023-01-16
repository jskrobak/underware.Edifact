
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class OTI : Segment
    {
        public OTI() : base("OTI", "Other insurance"){}

				[ElementInfo(0, "OBJECT IDENTIFICATION", "M", "5", "", "" )]
public E206 E206 { get; set; }
		[ElementInfo(1, "Payer responsibility level code", "M", "1", "an..3", "" )]
public string E9645 { get; set; }
		[ElementInfo(2, "DATE/TIME/PERIOD", "C", "2", "", "" )]
public E507 E507 { get; set; }
		[ElementInfo(3, "Service type code", "C", "10", "an..3", "" )]
public string E5267 { get; set; }
		[ElementInfo(4, "Monetary amount", "C", "4", "n..35", "" )]
public string E5004 { get; set; }
		[ElementInfo(5, "ADJUSTMENT INFORMATION", "C", "15", "", "" )]
public E030 E030 { get; set; }
		[ElementInfo(6, "Insurance cover type code", "C", "1", "an..3", "" )]
public string E4497 { get; set; }
		[ElementInfo(7, "Relationship description code", "C", "1", "an..3", "" )]
public string E9143 { get; set; }
		[ElementInfo(8, "Yes or no indicator code", "C", "1", "an..3", "" )]
public string E9607 { get; set; }

		
    }
}