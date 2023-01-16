using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class PDT : Segment
    {
        public PDT() : base("PDT", "Product information"){}

				[ElementInfo(0, "Product details type code qualifier", "C", "1", "an..3", "" )]
public string E7133 { get; set; }
		[ElementInfo(1, "PRODUCT CLASS DETAILS", "C", "26", "", "" )]
public E996 E996 { get; set; }

		
    }
}