using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class C280
    {
        [ElementInfo(0, "Measurement unit code", "M", "", "an..3", "")]
        public string E6411 { get; set; }
        [ElementInfo(1, "Range minimum value", "C", "", "n..18", "")]
        public string E6162 { get; set; }
        [ElementInfo(2, "Range maximum value", "C", "", "n..18", "")]
        public string E6152 { get; set; }

    }
}