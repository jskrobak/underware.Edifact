using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class INV : Segment
    {
        public INV() : base("INV", "Inventory management related details") { }

        [ElementInfo(0, "Inventory movement direction code", "C", "1", "an..3", "")]
        public string E4501 { get; set; }
        [ElementInfo(1, "Inventory type code", "C", "1", "an..3", "")]
        public string E7491 { get; set; }
        [ElementInfo(2, "Inventory movement reason code", "C", "1", "an..3", "")]
        public string E4499 { get; set; }
        [ElementInfo(3, "Inventory balance method code", "C", "1", "an..3", "")]
        public string E4503 { get; set; }
        [ElementInfo(4, "INSTRUCTION", "C", "1", "", "")]
        public C522 C522 { get; set; }


    }
}