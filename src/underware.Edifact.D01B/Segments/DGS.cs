using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class DGS : Segment
    {
        public DGS() : base("DGS", "Dangerous goods") { }

        [ElementInfo(0, "Dangerous goods regulations code", "C", "1", "an..3", "")]
        public string E8273 { get; set; }
        [ElementInfo(1, "HAZARD CODE", "C", "1", "", "")]
        public C205 C205 { get; set; }
        [ElementInfo(2, "UNDG INFORMATION", "C", "1", "", "")]
        public C234 C234 { get; set; }
        [ElementInfo(3, "DANGEROUS GOODS SHIPMENT FLASHPOINT", "C", "1", "", "")]
        public C223 C223 { get; set; }
        [ElementInfo(4, "Packaging danger level code", "C", "1", "an..3", "")]
        public string E8339 { get; set; }
        [ElementInfo(5, "Emergency procedure for ships identifier", "C", "1", "an..6", "")]
        public string E8364 { get; set; }
        [ElementInfo(6, "Hazard medical first aid guide identifier", "C", "1", "an..4", "")]
        public string E8410 { get; set; }
        [ElementInfo(7, "Transport emergency card identifier", "C", "1", "an..10", "")]
        public string E8126 { get; set; }
        [ElementInfo(8, "HAZARD IDENTIFICATION PLACARD DETAILS", "C", "1", "", "")]
        public C235 C235 { get; set; }
        [ElementInfo(9, "DANGEROUS GOODS LABEL", "C", "1", "", "")]
        public C236 C236 { get; set; }
        [ElementInfo(10, "Packing instruction type code", "C", "1", "an..3", "")]
        public string E8255 { get; set; }
        [ElementInfo(11, "Hazardous means of transport category code", "C", "1", "an..3", "")]
        public string E8325 { get; set; }
        [ElementInfo(12, "Hazardous cargo transport authorisation code", "C", "1", "an..3", "")]
        public string E8211 { get; set; }


    }
}