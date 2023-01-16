using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class UCM : Segment
    {
        public UCM() : base("UCM", "Message/package response") { }
        public UCM(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Message reference number", "M", "1", "an..14", "")]
        public string E0062 { get; set; }
        [ElementInfo(1, "MESSAGE IDENTIFIER", "M", "1", "", "")]
        public S009 S009 { get; set; }
        [ElementInfo(2, "Action, coded", "M", "1", "an..3", "")]
        public string E0083 { get; set; }
        [ElementInfo(3, "Syntax error, coded", "C", "1", "an..3", "")]
        public string E0085 { get; set; }
        [ElementInfo(4, "Service segment tag, coded", "C", "1", "a3", "")]
        public string E0013 { get; set; }
        [ElementInfo(5, "DATA ELEMENT IDENTIFICATION", "C", "1", "", "")]
        public S011 S011 { get; set; }


    }
}