using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class E003
    {
        [ElementInfo(0, "Attribute type description code", "M", "", "an..17", "")]
        public string E9021 { get; set; }
        [ElementInfo(1, "Attribute description", "C", "", "an..256", "")]
        public string E9018 { get; set; }

    }
}