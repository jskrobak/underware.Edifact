using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class CDS : Segment
    {
        public CDS() : base("CDS", "Code set identification"){}

				[ElementInfo(0, "CODE SET IDENTIFICATION", "M", "1", "", "" )]
public C702 C702 { get; set; }
		[ElementInfo(1, "Designated class code", "C", "1", "an..3", "" )]
public string E1507 { get; set; }
		[ElementInfo(2, "Maintenance operation code", "C", "1", "an..3", "" )]
public string E4513 { get; set; }

		
    }
}