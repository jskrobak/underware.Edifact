using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01A.Composites
{
    public class E362
    {
        [ElementInfo(0, "Time value", "C", "", "n4", "")]
        public string E2002 { get; set; }
        [ElementInfo(1, "Time value", "C", "", "n4", "")]
        public string E2002_0 { get; set; }
        [ElementInfo(2, "Time zone difference value", "C", "", "n..4", "")]
        public string E2020 { get; set; }
        [ElementInfo(3, "Date variation number", "C", "", "n..5", "")]
        public string E2148 { get; set; }

    }
}