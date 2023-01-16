using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D02B.Composites;

namespace underware.Edifact.D02B.Segments
{
    public class ITC : Segment
    {
        public ITC() : base("ITC", "Institutional claim"){}

				[ElementInfo(0, "INVOICE TYPE", "M", "1", "", "" )]
public E027 E027 { get; set; }
		[ElementInfo(1, "Quantity", "M", "4", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(2, "ADMISSION", "M", "1", "", "" )]
public E026 E026 { get; set; }
		[ElementInfo(3, "Discharge type description code", "M", "1", "an..3", "" )]
public string E9447 { get; set; }
		[ElementInfo(4, "BASIS OF SERVICE INFORMATION", "C", "9", "", "" )]
public E025 E025 { get; set; }

		
    }
}