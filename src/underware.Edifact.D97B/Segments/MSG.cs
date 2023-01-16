using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97B.Composites;

namespace underware.Edifact.D97B.Segments
{
    public class MSG : Segment
    {
        public MSG() : base("MSG", "Message type identification"){}

				[ElementInfo(0, "MESSAGE IDENTIFIER", "M", "1", "", "" )]
public C709 C709 { get; set; }
		[ElementInfo(1, "Class designator, coded", "C", "1", "an..3", "" )]
public string E1507 { get; set; }
		[ElementInfo(2, "Maintenance operation, coded", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}