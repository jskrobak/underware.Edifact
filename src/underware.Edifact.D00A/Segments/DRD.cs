
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class DRD : Segment
    {
        public DRD() : base("DRD", "Data representation details"){}

				[ElementInfo(0, "Structure component identifier", "C", "1", "an..35", "" )]
public string E7512 { get; set; }
		[ElementInfo(1, "Structure type code", "C", "1", "an..3", "" )]
public string E7515 { get; set; }
		[ElementInfo(2, "Data representation type code", "C", "1", "an..3", "" )]
public string E9169 { get; set; }
		[ElementInfo(3, "Size value", "C", "1", "n..15", "" )]
public string E6174 { get; set; }

		
    }
}