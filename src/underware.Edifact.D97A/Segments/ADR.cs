using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class ADR : Segment
    {
        public ADR() : base("ADR", "Address"){}

				[ElementInfo(0, "ADDRESS USAGE", "C", "1", "", "" )]
public C817 C817 { get; set; }
		[ElementInfo(1, "ADDRESS DETAILS", "C", "1", "", "" )]
public C090 C090 { get; set; }
		[ElementInfo(2, "City name", "C", "1", "an..35", "" )]
public string E3164 { get; set; }
		[ElementInfo(3, "Postcode identification", "C", "1", "an..9", "" )]
public string E3251 { get; set; }
		[ElementInfo(4, "Country, coded", "C", "1", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(5, "COUNTRY SUB-ENTITY DETAILS", "C", "1", "", "" )]
public C819 C819 { get; set; }
		[ElementInfo(6, "LOCATION IDENTIFICATION", "C", "1", "", "" )]
public C517 C517 { get; set; }

		
    }
}