using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S4.Composites
{
    public class S022
    {
        [ElementInfo(0, "Length of object in octets of bits", "M", "", "n..18", "")]
        public string E0810 { get; set; }
        [ElementInfo(1, "Number of segments before object", "C", "", "n..3", "")]
        public string E0814 { get; set; }
        [ElementInfo(2, "Sequence of transfers", "C", "", "n..2", "")]
        public string E0070 { get; set; }
        [ElementInfo(3, "First and last transfer", "C", "", "a1", "")]
        public string E0073 { get; set; }

    }
}