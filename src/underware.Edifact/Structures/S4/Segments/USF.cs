using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class USF : Segment
    {
        public USF() : base("USF", "Key management function") { }
        public USF(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Key management function qualifier", "C", "1", "an..3", "")]
        public string E0579 { get; set; }
        [ElementInfo(1, "LIST PARAMETER", "C", "1", "", "")]
        public S504 S504 { get; set; }
        [ElementInfo(2, "Security status, coded", "C", "1", "an..3", "")]
        public string E0567 { get; set; }
        [ElementInfo(3, "Certificate sequence number", "C", "1", "n..4", "")]
        public string E0572 { get; set; }
        [ElementInfo(4, "Filter function, coded", "C", "1", "an..3", "")]
        public string E0505 { get; set; }


    }
}