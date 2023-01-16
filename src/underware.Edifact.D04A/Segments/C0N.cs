using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class CON : Segment
    {
        public CON() : base("CON", "Contact information"){}

				[ElementInfo(0, "CONTACT INFORMATION", "C", "20", "", "" )]
public E966 E966 { get; set; }

		
    }
}