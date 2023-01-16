using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C223
    {
        [ElementInfo(0, "Shipment flashpoint value", "C", "", "n3", "")]
        public string E7106 { get; set; }
        [ElementInfo(1, "Measurement unit code", "C", "", "an..3", "")]
        public string E6411 { get; set; }

    }
}