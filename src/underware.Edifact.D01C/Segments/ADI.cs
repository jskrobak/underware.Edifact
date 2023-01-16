using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01C.Composites;

namespace underware.Edifact.D01C.Segments
{
    public class ADI : Segment
    {
        public ADI() : base("ADI", "Health care claim adjudication information"){}

				[ElementInfo(0, "OBJECT IDENTIFICATION", "M", "3", "", "" )]
public E206 E206 { get; set; }
		[ElementInfo(1, "SERVICE", "C", "3", "", "" )]
public E021 E021 { get; set; }
		[ElementInfo(2, "Action request/notification description code", "C", "1", "an..3", "" )]
public string E1229 { get; set; }
		[ElementInfo(3, "MONETARY AMOUNT", "C", "15", "", "" )]
public E017 E017 { get; set; }
		[ElementInfo(4, "Quantity", "C", "3", "an..35", "" )]
public string E6060 { get; set; }
		[ElementInfo(5, "ADJUSTMENT INFORMATION", "C", "15", "", "" )]
public E030 E030 { get; set; }
		[ElementInfo(6, "Policy limitation identifier", "C", "4", "an..10", "" )]
public string E9620 { get; set; }
		[ElementInfo(7, "Product group name code", "C", "1", "an..25", "" )]
public string E5389 { get; set; }
		[ElementInfo(8, "DATE/TIME/PERIOD", "C", "1", "", "" )]
public E507 E507 { get; set; }
		[ElementInfo(9, "Diagnosis category code", "C", "1", "an..3", "" )]
public string E9639 { get; set; }
		[ElementInfo(10, "Percentage", "C", "1", "n..10", "" )]
public string E5482 { get; set; }

		
    }
}