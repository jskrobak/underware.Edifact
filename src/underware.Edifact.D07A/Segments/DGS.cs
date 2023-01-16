using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
    public class DGS : Segment
    {
        public DGS() : base("DGS", "DANGEROUS GOODS"){}

				[ElementInfo(0, "DANGEROUS GOODS REGULATIONS CODE", "Conditional", "", "", "" )]
public string E8273 { get; set; }
		[ElementInfo(1, "HAZARD CODE", "Conditional", "", "", "" )]
public C205 C205 { get; set; }
		[ElementInfo(2, "UNDG INFORMATION", "Conditional", "", "", "" )]
public C234 C234 { get; set; }
		[ElementInfo(3, "DANGEROUS GOODS SHIPMENT FLASHPOINT", "Conditional", "", "", "" )]
public C223 C223 { get; set; }
		[ElementInfo(4, "PACKAGING DANGER LEVEL CODE", "Conditional", "", "", "" )]
public string E8339 { get; set; }
		[ElementInfo(5, "EMERGENCY PROCEDURE FOR SHIPS IDENTIFIER", "Conditional", "", "", "" )]
public string E8364 { get; set; }
		[ElementInfo(6, "HAZARD MEDICAL FIRST AID GUIDE IDENTIFIER", "Conditional", "", "", "" )]
public string E8410 { get; set; }
		[ElementInfo(7, "TRANSPORT EMERGENCY CARD IDENTIFIER", "Conditional", "", "", "" )]
public string E8126 { get; set; }
		[ElementInfo(8, "HAZARD IDENTIFICATION PLACARD DETAILS", "Conditional", "", "", "" )]
public C235 C235 { get; set; }
		[ElementInfo(9, "DANGEROUS GOODS LABEL", "Conditional", "", "", "" )]
public C236 C236 { get; set; }
		[ElementInfo(10, "PACKING INSTRUCTION TYPE CODE", "Conditional", "", "", "" )]
public string E8255 { get; set; }
		[ElementInfo(11, "TRANSPORT MEANS DESCRIPTION CODE", "Conditional", "", "", "" )]
public string E8179 { get; set; }
		[ElementInfo(12, "HAZARDOUS CARGO TRANSPORT AUTHORISATION CODE", "Conditional", "", "", "" )]
public string E8211 { get; set; }

		
    }
}