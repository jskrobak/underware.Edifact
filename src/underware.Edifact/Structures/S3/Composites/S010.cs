using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S3.Composites
{
    public class S010
    {
        [ElementInfo(0, "Sequence of transfers", "M", "", "n..2", "")]
        public string E0070 { get; set; }

        [ElementInfo(1, "Message version number", "M", "", "an..3", "")]
        public string E0073 { get; set; }
    }
}
