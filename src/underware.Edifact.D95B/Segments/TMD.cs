using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
{
    public class TMD : Segment
    {
        public TMD() : base("TMD", "Transport movement details"){}

				[ElementInfo(0, "MOVEMENT TYPE", "C", "1", "", "" )]
public C219 C219 { get; set; }
		[ElementInfo(1, "Equipment plan", "C", "1", "an..26", "" )]
public string E8332 { get; set; }
		[ElementInfo(2, "Haulage arrangements, coded", "C", "1", "an..3", "" )]
public string E8341 { get; set; }

		
    }
}