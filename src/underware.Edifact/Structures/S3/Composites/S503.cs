using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S3.Composites
{
    public class S503
    {
        [ElementInfo(0, "Algorithm parameter qualifier", "M", "", "an..3", "")]
        public string E0531 { get; set; }
        [ElementInfo(1, "Algorithm parameter value", "M", "", "an..512", "")]
        public string E0554 { get; set; }

    }
}