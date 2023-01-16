using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S3.Composites
{
    public class S011
    {
        [ElementInfo(0, "Erroneous data element position in segment", "M", "", "n..3", "")]
        public string E0098 { get; set; }
        [ElementInfo(1, "Erroneous component data element position", "C", "", "n..3", "")]
        public string E0104 { get; set; }

    }
}