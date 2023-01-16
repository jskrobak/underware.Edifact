using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S301
    {
        [ElementInfo(0, "Sender sequence number", "C", "", "n..6", "")]
        public string E0320 { get; set; }
        [ElementInfo(1, "Transfer position, coded", "C", "", "a1", "")]
        public string E0323 { get; set; }
        [ElementInfo(2, "Duplicate Indicator", "C", "", "a1", "")]
        public string E0325 { get; set; }

    }
}