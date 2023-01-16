using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class NAD : Segment
    {
        public NAD() : base("NAD", "NAME AND ADDRESS"){}

				[ElementInfo(0, "PARTY FUNCTION CODE QUALIFIER", "Mandatory", "", "", "" )]
public string E3035 { get; set; }
		[ElementInfo(1, "PARTY IDENTIFICATION DETAILS", "Conditional", "", "", "" )]
public C082 C082 { get; set; }
		[ElementInfo(2, "NAME AND ADDRESS", "Conditional", "", "", "" )]
public C058 C058 { get; set; }
		[ElementInfo(3, "PARTY NAME", "Conditional", "", "", "" )]
public C080 C080 { get; set; }
		[ElementInfo(4, "STREET", "Conditional", "", "", "" )]
public C059 C059 { get; set; }
		[ElementInfo(5, "CITY NAME", "Conditional", "", "", "" )]
public string E3164 { get; set; }
		[ElementInfo(6, "COUNTRY SUBDIVISION DETAILS", "Conditional", "", "", "" )]
public C819 C819 { get; set; }
		[ElementInfo(7, "POSTAL IDENTIFICATION CODE", "Conditional", "", "", "" )]
public string E3251 { get; set; }
		[ElementInfo(8, "COUNTRY IDENTIFIER", "Conditional", "", "", "" )]
public string E3207 { get; set; }

		
    }
}