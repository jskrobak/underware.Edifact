
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class MOV : Segment
    {
        public MOV() : base("MOV", "Car delivery instruction"){}

				[ElementInfo(0, "MOVEMENT DETAILS", "C", "1", "", "" )]
public E995 E995 { get; set; }
		[ElementInfo(1, "Units quantity", "C", "1", "n..15", "" )]
public string E6350 { get; set; }
		[ElementInfo(2, "Language name code", "C", "1", "an..3", "" )]
public string E3453 { get; set; }

		
    }
}