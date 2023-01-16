using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D94A.Composites
{
    public class S002
    {
        [ElementInfo(0, "Interchange sender identification", "M", "", "an..35", "")]
        public string E0004 { get; set; }
        [ElementInfo(1, "Identification code qualifier", "C", "", "an..4", "")]
        public string E0007 { get; set; }
        [ElementInfo(2, "Interchange sender internal identification", "C", "", "an..35", "")]
        public string E0008 { get; set; }
        [ElementInfo(3, "Interchange sender internal sub-identification", "C", "", "an..35", "")]
        public string E0042 { get; set; }

    }
}