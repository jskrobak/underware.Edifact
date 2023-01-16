using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D00B.Composites
{
    public class C232
    {
        [ElementInfo(0, "Government agency identification code", "C", "", "an..3", "")]
        public string E9415 { get; set; }
        [ElementInfo(1, "Government involvement code", "C", "", "an..3", "")]
        public string E9411 { get; set; }
        [ElementInfo(2, "Government action code", "C", "", "an..3", "")]
        public string E9417 { get; set; }
        [ElementInfo(3, "Government procedure code", "C", "", "an..3", "")]
        public string E9353 { get; set; }

    }
}