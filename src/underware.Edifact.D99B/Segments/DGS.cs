using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D99B.Composites;

namespace underware.Edifact.D99B.Segments
{
    public class DGS : Segment
    {
        public DGS() : base("DGS", "Dangerous goods"){}

				[ElementInfo(0, "Dangerous goods regulations code", "C", "1", "an..3", "" )]
public string E8273 { get; set; }
		[ElementInfo(1, "HAZARD CODE", "C", "1", "", "" )]
public C205 C205 { get; set; }
		[ElementInfo(2, "UNDG INFORMATION", "C", "1", "", "" )]
public C234 C234 { get; set; }
		[ElementInfo(3, "DANGEROUS GOODS SHIPMENT FLASHPOINT", "C", "1", "", "" )]
public C223 C223 { get; set; }
		[ElementInfo(4, "Packing group, coded", "C", "1", "an..3", "" )]
public string E8339 { get; set; }
		[ElementInfo(5, "EMS number", "C", "1", "an..6", "" )]
public string E8364 { get; set; }
		[ElementInfo(6, "MFAG", "C", "1", "an..4", "" )]
public string E8410 { get; set; }
		[ElementInfo(7, "Trem card number", "C", "1", "an..10", "" )]
public string E8126 { get; set; }
		[ElementInfo(8, "HAZARD IDENTIFICATION PLACARD DETAILS", "C", "1", "", "" )]
public C235 C235 { get; set; }
		[ElementInfo(9, "DANGEROUS GOODS LABEL", "C", "1", "", "" )]
public C236 C236 { get; set; }
		[ElementInfo(10, "Packing instruction, coded", "C", "1", "an..3", "" )]
public string E8255 { get; set; }
		[ElementInfo(11, "Category of means of transport, coded", "C", "1", "an..3", "" )]
public string E8325 { get; set; }
		[ElementInfo(12, "Permission for transport, coded", "C", "1", "an..3", "" )]
public string E8211 { get; set; }

		
    }
}