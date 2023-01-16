using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class ELM : Segment
    {
        public ELM() : base("ELM", "Simple data element details"){}

				[ElementInfo(0, "Simple data element tag", "M", "1", "an..4", "" )]
public string E9150 { get; set; }
		[ElementInfo(1, "Simple data element character representation, coded", "C", "1", "an..3", "" )]
public string E9153 { get; set; }
		[ElementInfo(2, "Simple data element length type, coded", "C", "1", "an..3", "" )]
public string E9155 { get; set; }
		[ElementInfo(3, "Simple data element maximum length", "C", "1", "n..3", "" )]
public string E9156 { get; set; }
		[ElementInfo(4, "Simple data element minimum length", "C", "1", "n..3", "" )]
public string E9158 { get; set; }
		[ElementInfo(5, "Code set indicator, coded", "C", "1", "an..3", "" )]
public string E9161 { get; set; }
		[ElementInfo(6, "Class designator, coded", "C", "1", "an..3", "" )]
public string E1507 { get; set; }
		[ElementInfo(7, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }
		[ElementInfo(8, "Significant digits", "C", "1", "n..2", "" )]
public string E6432 { get; set; }

		
    }
}