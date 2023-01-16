using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D01B.Composites
{
    public class C045
    {
        [ElementInfo(0, "Level one identifier", "C", "", "an..17", "")]
        public string E7436 { get; set; }
        [ElementInfo(1, "Level two identifier", "C", "", "an..17", "")]
        public string E7438 { get; set; }
        [ElementInfo(2, "Level three identifier", "C", "", "an..17", "")]
        public string E7440 { get; set; }
        [ElementInfo(3, "Level four identifier", "C", "", "an..17", "")]
        public string E7442 { get; set; }
        [ElementInfo(4, "Level five identifier", "C", "", "an..17", "")]
        public string E7444 { get; set; }
        [ElementInfo(5, "Level six identifier", "C", "", "an..17", "")]
        public string E7446 { get; set; }

    }
}