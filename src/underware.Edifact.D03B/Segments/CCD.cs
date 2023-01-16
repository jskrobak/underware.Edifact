using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03B.Composites;

namespace underware.Edifact.D03B.Segments
{
    public class CCD : Segment
    {
        public CCD() : base("CCD", "Credit cover details"){}

				[ElementInfo(0, "Credit cover request type code", "C", "1", "an..3", "" )]
public string E4505 { get; set; }
		[ElementInfo(1, "Credit cover response type code", "C", "1", "an..3", "" )]
public string E4507 { get; set; }
		[ElementInfo(2, "Credit cover response reason code", "C", "1", "an..3", "" )]
public string E4509 { get; set; }

		
    }
}