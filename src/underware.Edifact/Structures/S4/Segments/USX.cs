using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class USX : Segment
    {
        public USX() : base("USX", "Security references") { }
        public USX(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Interchange control reference", "M", "1", "an..14", "")]
        public string E0020 { get; set; }
        [ElementInfo(1, "INTERCHANGE SENDER", "C", "1", "", "")]
        public S002 S002 { get; set; }
        [ElementInfo(2, "INTERCHANGE RECIPIENT", "C", "1", "", "")]
        public S003 S003 { get; set; }
        [ElementInfo(3, "Group reference number", "C", "1", "an..14", "")]
        public string E0048 { get; set; }
        [ElementInfo(4, "APPLICATION SENDER IDENTIFICATION", "C", "1", "", "")]
        public S006 S006 { get; set; }
        [ElementInfo(5, "APPLICATION RECIPIENT IDENTIFICATION", "C", "1", "", "")]
        public S007 S007 { get; set; }
        [ElementInfo(6, "Message reference number", "C", "1", "an..14", "")]
        public string E0062 { get; set; }
        [ElementInfo(7, "MESSAGE IDENTIFIER", "C", "1", "", "")]
        public S009 S009 { get; set; }
        [ElementInfo(8, "Package reference number", "C", "1", "an..35", "")]
        public string E0800 { get; set; }
        [ElementInfo(9, "SECURITY DATE AND TIME", "C", "1", "", "")]
        public S501 S501 { get; set; }


    }
}