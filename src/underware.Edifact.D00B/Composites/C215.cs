using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class C215
    {
        [ElementInfo(0, "Sealing party name code", "C", "", "an..3", "")]
        public string E9303 { get; set; }
        [ElementInfo(1, "Code list identification code", "C", "", "an..17", "")]
        public string E1131 { get; set; }
        [ElementInfo(2, "Code list responsible agency code", "C", "", "an..3", "")]
        public string E3055 { get; set; }
        [ElementInfo(3, "Sealing party name", "C", "", "an..35", "")]
        public string E9302 { get; set; }

    }
}