using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class ADS : Segment
    {
        public ADS() : base("ADS", "Address"){}

				[ElementInfo(0, "ADDRESS USAGE", "C", "1", "", "" )]
public E817 E817 { get; set; }
		[ElementInfo(1, "ADDRESS DETAILS", "C", "1", "", "" )]
public E001 E001 { get; set; }
		[ElementInfo(2, "City name", "C", "1", "an..35", "" )]
public string E3164 { get; set; }
		[ElementInfo(3, "Postal identification code", "C", "1", "an..17", "" )]
public string E3251 { get; set; }
		[ElementInfo(4, "Country name code", "C", "1", "an..3", "" )]
public string E3207 { get; set; }
		[ElementInfo(5, "COUNTRY SUB-ENTITY DETAILS", "C", "1", "", "" )]
public E819 E819 { get; set; }
		[ElementInfo(6, "LOCATION IDENTIFICATION", "C", "1", "", "" )]
public E517 E517 { get; set; }

		
    }
}