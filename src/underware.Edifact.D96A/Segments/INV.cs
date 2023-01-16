using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;

namespace underware.Edifact.D96A.Segments
{
    public class INV : Segment
    {
        public INV() : base("INV", "Inventory management related details"){}

				[ElementInfo(0, "Inventory movement direction, coded", "C", "1", "an..3", "" )]
public string E4501 { get; set; }
		[ElementInfo(1, "Type of inventory affected, coded", "C", "1", "an..3", "" )]
public string E7491 { get; set; }
		[ElementInfo(2, "Reason for inventory movement, coded", "C", "1", "an..3", "" )]
public string E4499 { get; set; }
		[ElementInfo(3, "Inventory balance method, coded", "C", "1", "an..3", "" )]
public string E4503 { get; set; }
		[ElementInfo(4, "INSTRUCTION", "C", "1", "", "" )]
public C522 C522 { get; set; }

		
    }
}