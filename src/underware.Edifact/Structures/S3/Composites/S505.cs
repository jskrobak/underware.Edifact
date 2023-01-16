using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S3.Composites
{
    public class S505
    {
        [ElementInfo(0, "Service character for signature qualifier", "M", "", "an..3", "")]
        public string E0551 { get; set; }
        [ElementInfo(1, "Service character for signature", "M", "", "an..4", "")]
        public string E0548 { get; set; }

    }
}