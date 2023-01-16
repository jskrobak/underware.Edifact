using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class ELM : Segment
    {
        public ELM() : base("ELM", "Simple data element details"){}

				[ElementInfo(0, "Simple data element tag identifier", "M", "1", "an..4", "" )]
public string E9150 { get; set; }
		[ElementInfo(1, "Simple data element character representation code", "C", "1", "an..3", "" )]
public string E9153 { get; set; }
		[ElementInfo(2, "Length type code", "C", "1", "an..3", "" )]
public string E9155 { get; set; }
		[ElementInfo(3, "Simple data element maximum length measure", "C", "1", "n..3", "" )]
public string E9156 { get; set; }
		[ElementInfo(4, "Simple data element minimum length measure", "C", "1", "n..3", "" )]
public string E9158 { get; set; }
		[ElementInfo(5, "Code set indicator code", "C", "1", "an..3", "" )]
public string E9161 { get; set; }
		[ElementInfo(6, "Designated class code", "C", "1", "an..3", "" )]
public string E1507 { get; set; }
		[ElementInfo(7, "Maintenance operation code", "C", "1", "an..3", "" )]
public string E4513 { get; set; }
		[ElementInfo(8, "Significant digits quantity", "C", "1", "n..2", "" )]
public string E6432 { get; set; }

		
    }
}