using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D03A.Composites;

namespace underware.Edifact.D03A.Segments
{
    public class CST : Segment
    {
        public CST() : base("CST", "Customs status of goods"){}

				[ElementInfo(0, "Goods item number", "C", "1", "n..5", "" )]
public string E1496 { get; set; }
		[ElementInfo(1, "CUSTOMS IDENTITY CODES", "C", "1", "", "" )]
public C246 C246 { get; set; }
		[ElementInfo(2, "CUSTOMS IDENTITY CODES", "C", "1", "", "" )]
public C246 C246_0 { get; set; }
		[ElementInfo(3, "CUSTOMS IDENTITY CODES", "C", "1", "", "" )]
public C246 C246_1 { get; set; }
		[ElementInfo(4, "CUSTOMS IDENTITY CODES", "C", "1", "", "" )]
public C246 C246_2 { get; set; }
		[ElementInfo(5, "CUSTOMS IDENTITY CODES", "C", "1", "", "" )]
public C246 C246_3 { get; set; }

		
    }
}