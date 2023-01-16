using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class PSD : Segment
    {
        public PSD() : base("PSD", "Physical sample description"){}

				[ElementInfo(0, "Sample process step code", "C", "1", "an..3", "" )]
public string E4407 { get; set; }
		[ElementInfo(1, "Sample selection method code", "C", "1", "an..3", "" )]
public string E7039 { get; set; }
		[ElementInfo(2, "FREQUENCY DETAILS", "C", "1", "", "" )]
public C526 C526 { get; set; }
		[ElementInfo(3, "Sample state code", "C", "1", "an..3", "" )]
public string E7045 { get; set; }
		[ElementInfo(4, "Sample direction code", "C", "1", "an..3", "" )]
public string E7047 { get; set; }
		[ElementInfo(5, "SAMPLE LOCATION DETAILS", "C", "1", "", "" )]
public C514 C514 { get; set; }
		[ElementInfo(6, "SAMPLE LOCATION DETAILS", "C", "1", "", "" )]
public C514 C514_0 { get; set; }
		[ElementInfo(7, "SAMPLE LOCATION DETAILS", "C", "1", "", "" )]
public C514 C514_1 { get; set; }

		
    }
}