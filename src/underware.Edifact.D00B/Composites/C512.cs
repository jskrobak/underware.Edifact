using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class C512
    {
        [ElementInfo(0, "Size type code qualifier", "C", "", "an..3", "")]
        public string E6173 { get; set; }
        [ElementInfo(1, "Size value", "C", "", "n..15", "")]
        public string E6174 { get; set; }

    }
}