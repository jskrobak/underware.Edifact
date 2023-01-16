using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class DSI : Segment
    {
        public DSI() : base("DSI", "Data set identification"){}

				[ElementInfo(0, "DATA SET IDENTIFICATION", "M", "1", "", "" )]
public C782 C782 { get; set; }
		[ElementInfo(1, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "" )]
public C082 C082 { get; set; }
		[ElementInfo(2, "Status description code", "C", "1", "an..3", "" )]
public string E4405 { get; set; }
		[ElementInfo(3, "SEQUENCE INFORMATION", "C", "1", "", "" )]
public C286 C286 { get; set; }
		[ElementInfo(4, "Revision identifier", "C", "1", "an..6", "" )]
public string E1060 { get; set; }

		
    }
}