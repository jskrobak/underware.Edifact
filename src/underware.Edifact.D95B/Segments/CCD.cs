using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D95B.Composites;

namespace underware.Edifact.D95B.Segments
{
    public class CCD : Segment
    {
        public CCD() : base("CCD", "Credit cover details"){}

				[ElementInfo(0, "Credit cover request, coded", "C", "1", "an..3", "" )]
public string E4505 { get; set; }
		[ElementInfo(1, "Credit cover response, coded", "C", "1", "an..3", "" )]
public string E4507 { get; set; }
		[ElementInfo(2, "Credit cover reason, coded", "C", "1", "an..3", "" )]
public string E4509 { get; set; }

		
    }
}