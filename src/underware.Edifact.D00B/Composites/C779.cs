using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class C779
    {
        [ElementInfo(0, "Array cell structure identifier", "M", "", "an..35", "")]
        public string E9428 { get; set; }
        [ElementInfo(1, "Object identification code qualifier", "C", "", "an..3", "")]
        public string E7405 { get; set; }

    }
}