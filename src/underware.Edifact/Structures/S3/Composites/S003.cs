using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S3.Composites
{
    public class S003
    {
        [ElementInfo(0, "Recipient identification", "M", "", "an..35", "")]
        public string E0010 { get; set; }
        [ElementInfo(1, "Partner identification code qualifier", "C", "", "an..4", "")]
        public string E0007 { get; set; }
        [ElementInfo(2, "Routing address", "C", "", "an..14", "")]
        public string E0014 { get; set; }

    }
}