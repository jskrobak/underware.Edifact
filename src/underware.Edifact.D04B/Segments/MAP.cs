using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04B.Composites;

namespace underware.Edifact.D04B.Segments
{
    public class MAP : Segment
    {
        public MAP() : base("MAP", "Message application product information"){}

				[ElementInfo(0, "INSTRUCTION INFORMATION", "C", "1", "", "" )]
public E022 E022 { get; set; }
		[ElementInfo(1, "Party name", "C", "1", "an..35", "" )]
public string E3036 { get; set; }
		[ElementInfo(2, "MESSAGE APPLICATION PRODUCT SPECIFICATION", "C", "1", "", "" )]
public E031 E031 { get; set; }

		
    }
}