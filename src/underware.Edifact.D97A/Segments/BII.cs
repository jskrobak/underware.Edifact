using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class BII : Segment
    {
        public BII() : base("BII", "Structure identification"){}

				[ElementInfo(0, "Indexing structure qualifier", "M", "1", "an..3", "" )]
public string E7429 { get; set; }
		[ElementInfo(1, "BILL LEVEL IDENTIFICATION", "M", "1", "", "" )]
public C045 C045 { get; set; }
		[ElementInfo(2, "Item number", "C", "1", "an..35", "" )]
public string E7140 { get; set; }

		
    }
}