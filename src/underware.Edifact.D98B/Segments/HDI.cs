using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D98B.Composites;

namespace underware.Edifact.D98B.Segments
{
    public class HDI : Segment
    {
        public HDI() : base("HDI", "Hardware device information"){}

				[ElementInfo(0, "Communication number", "C", "1", "an..512", "" )]
public string E3148 { get; set; }
		[ElementInfo(1, "Department or employee identification", "C", "1", "an..17", "" )]
public string E3413 { get; set; }
		[ElementInfo(2, "Computer environment, coded", "C", "1", "an..3", "" )]
public string E1511 { get; set; }
		[ElementInfo(3, "ATTRIBUTE INFORMATION", "C", "9", "", "" )]
public E003 E003 { get; set; }

		
    }
}