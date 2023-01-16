using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S3.Composites
{
    public class S006
    {
        [ElementInfo(0, "Sender identification", "M", "", "an..35", "")]
        public string E0040 { get; set; }
        [ElementInfo(1, "Partner identification code qualifier", "C", "", "an..4", "")]
        public string E0007 { get; set; }

    }
}