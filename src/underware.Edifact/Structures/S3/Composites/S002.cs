using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S3.Composites
{
    public class S002
    {
        [ElementInfo(0, "Sender identification", "M", "", "an..35", "")]
        public string E0004 { get; set; }
        [ElementInfo(1, "Partner identification code qualifier", "C", "", "an..4", "")]
        public string E0007 { get; set; }
        [ElementInfo(2, "Address for reverse routing", "C", "", "an..14", "")]
        public string E0008 { get; set; }

    }
}