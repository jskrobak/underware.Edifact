using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class E034
    {
        [ElementInfo(0, "Time zone identifier", "M", "", "an..3", "")]
        public string E2029 { get; set; }
        [ElementInfo(1, "Time zone difference value", "C", "", "n..4", "")]
        public string E2020 { get; set; }

    }
}