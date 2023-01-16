using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UCF : Segment
    {
        public UCF() : base("UCF", "Group response") { }
        public UCF(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Group reference number", "M", "1", "an..14", "")]
        public string E0048 { get; set; }
        [ElementInfo(1, "APPLICATION SENDER IDENTIFICATION", "C", "1", "", "")]
        public S006 S006 { get; set; }
        [ElementInfo(2, "APPLICATION RECIPIENT IDENTIFICATION", "C", "1", "", "")]
        public S007 S007 { get; set; }
        [ElementInfo(3, "Action, coded", "M", "1", "an..3", "")]
        public string E0083 { get; set; }
        [ElementInfo(4, "Syntax error, coded", "C", "1", "an..3", "")]
        public string E0085 { get; set; }
        [ElementInfo(5, "Service segment tag, coded", "C", "1", "an..3", "")]
        public string E0135 { get; set; }
        [ElementInfo(6, "DATA ELEMENT IDENTIFICATION", "C", "1", "", "")]
        public S011 S011 { get; set; }
        [ElementInfo(7, "Security reference number", "C", "1", "an..14", "")]
        public string E0534 { get; set; }
        [ElementInfo(8, "Security segment position", "C", "1", "n..6", "")]
        public string E0138 { get; set; }


    }
}