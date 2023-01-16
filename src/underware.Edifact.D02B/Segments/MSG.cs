using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class MSG : Segment
    {
        public MSG() : base("MSG", "Message type identification"){}

				[ElementInfo(0, "MESSAGE IDENTIFIER", "M", "1", "", "" )]
public C709 C709 { get; set; }
		[ElementInfo(1, "Designated class code", "C", "1", "an..3", "" )]
public string E1507 { get; set; }
		[ElementInfo(2, "Maintenance operation code", "C", "1", "an..3", "" )]
public string E4513 { get; set; }
		[ElementInfo(3, "RELATIONSHIP", "C", "1", "", "" )]
public C941 C941 { get; set; }

		
    }
}