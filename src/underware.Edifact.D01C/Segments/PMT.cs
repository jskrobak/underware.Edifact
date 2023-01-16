using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class PMT : Segment
    {
        public PMT() : base("PMT", "Payment information"){}

				[ElementInfo(0, "PAYMENT DETAILS", "C", "99", "", "" )]
public E977 E977 { get; set; }
		[ElementInfo(1, "CREDIT CARD INFORMATION", "C", "99", "", "" )]
public E978 E978 { get; set; }

		
    }
}