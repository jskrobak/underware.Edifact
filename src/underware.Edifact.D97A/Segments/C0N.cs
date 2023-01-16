using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D97A.Composites;

namespace underware.Edifact.D97A.Segments
{
    public class CON : Segment
    {
        public CON() : base("CON", "Contact information"){}

				[ElementInfo(0, "CONTACT INFORMATION", "C", "5", "", "" )]
public E966 E966 { get; set; }

		
    }
}