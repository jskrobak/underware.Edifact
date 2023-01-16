using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class USD : Segment
    {
        public USD() : base("USD", "Data encryption header") { }
        public USD(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Length of data in octets of bits", "M", "1", "n..18", "")]
        public string E0556 { get; set; }
        [ElementInfo(1, "Encryption reference number", "C", "1", "an..35", "")]
        public string E0518 { get; set; }
        [ElementInfo(2, "Number of padding bytes", "C", "1", "n..2", "")]
        public string E0582 { get; set; }


    }
}