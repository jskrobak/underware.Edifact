using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UCM : Segment
    {
        public UCM() : base("UCM", "Message/package response") { }
        public UCM(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Message reference number", "C", "1", "an..14", "")]
        public string E0062 { get; set; }
        [ElementInfo(1, "MESSAGE IDENTIFIER", "C", "1", "", "")]
        public S009 S009 { get; set; }
        [ElementInfo(2, "Action, coded", "M", "1", "an..3", "")]
        public string E0083 { get; set; }
        [ElementInfo(3, "Syntax error, coded", "C", "1", "an..3", "")]
        public string E0085 { get; set; }
        [ElementInfo(4, "Service segment tag, coded", "C", "1", "an..3", "")]
        public string E0135 { get; set; }
        [ElementInfo(5, "DATA ELEMENT IDENTIFICATION", "C", "1", "", "")]
        public S011 S011 { get; set; }
        [ElementInfo(6, "Package reference number", "C", "1", "an..35", "")]
        public string E0800 { get; set; }
        [ElementInfo(7, "REFERENCE IDENTIFICATION", "C", "99", "", "")]
        public S020 S020 { get; set; }
        [ElementInfo(8, "Security reference number", "C", "1", "an..14", "")]
        public string E0534 { get; set; }
        [ElementInfo(9, "Security segment position", "C", "1", "n..6", "")]
        public string E0138 { get; set; }


    }
}