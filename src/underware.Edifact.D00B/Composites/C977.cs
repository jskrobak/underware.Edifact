using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class C977
    {
        [ElementInfo(0, "Period detail description code", "C", "", "an..3", "")]
        public string E2025 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Period detail description", "C", "", "an..35", "")]
        public string E2024 { get; set; }

    }
}