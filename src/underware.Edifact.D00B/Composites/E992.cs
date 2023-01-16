using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class E992
    {
        [ElementInfo(0, "First related location name code", "C", "", "an..25", "")]
        public string E3223 { get; set; }
        [ElementInfo(1, "Second related location name code", "C", "", "an..25", "")]
        public string E3233 { get; set; }

    }
}