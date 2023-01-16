using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class CPS : Segment
    {
        public CPS() : base("CPS", "Consignment packing sequence"){}

				[ElementInfo(0, "Hierarchical structure level identifier", "M", "1", "an..35", "" )]
public string E7164 { get; set; }
		[ElementInfo(1, "Hierarchical structure parent identifier", "C", "1", "an..35", "" )]
public string E7166 { get; set; }
		[ElementInfo(2, "Packaging level, coded", "C", "1", "an..3", "" )]
public string E7075 { get; set; }

		
    }
}