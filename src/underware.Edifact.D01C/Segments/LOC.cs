using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class LOC : Segment
    {
        public LOC() : base("LOC", "Place/location identification"){}

				[ElementInfo(0, "Location function code qualifier", "M", "1", "an..3", "" )]
public string E3227 { get; set; }
		[ElementInfo(1, "LOCATION IDENTIFICATION", "C", "1", "", "" )]
public C517 C517 { get; set; }
		[ElementInfo(2, "RELATED LOCATION ONE IDENTIFICATION", "C", "1", "", "" )]
public C519 C519 { get; set; }
		[ElementInfo(3, "RELATED LOCATION TWO IDENTIFICATION", "C", "1", "", "" )]
public C553 C553 { get; set; }
		[ElementInfo(4, "Relation code", "C", "1", "an..3", "" )]
public string E5479 { get; set; }

		
    }
}