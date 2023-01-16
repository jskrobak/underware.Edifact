using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99A.Composites;

namespace underware.Edifact.D99A.Segments
{
    public class CPS : Segment
    {
        public CPS() : base("CPS", "Consignment packing sequence"){}

				[ElementInfo(0, "Hierarchical id. number", "M", "1", "an..35", "" )]
public string E7164 { get; set; }
		[ElementInfo(1, "Hierarchical parent id.", "C", "1", "an..12", "" )]
public string E7166 { get; set; }
		[ElementInfo(2, "Packaging level, coded", "C", "1", "an..3", "" )]
public string E7075 { get; set; }

		
    }
}