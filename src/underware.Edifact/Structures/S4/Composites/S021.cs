using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S021
    {
        [ElementInfo(0, "Object type qualifier", "M", "", "an..3", "")]
        public string E0805 { get; set; }
        [ElementInfo(1, "Object type attribute identification", "C", "", "an..256", "")]
        public string E0809 { get; set; }
        [ElementInfo(2, "Object type attribute", "C", "", "an..256", "")]
        public string E0808 { get; set; }
        [ElementInfo(3, "Controlling agency, coded", "C", "", "an..3", "")]
        public string E0051 { get; set; }

    }
}