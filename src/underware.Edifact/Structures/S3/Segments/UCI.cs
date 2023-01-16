using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class UCI : Segment
    {
        public UCI() : base("UCI", "Interchange response") { }
        public UCI(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Interchange control reference", "M", "1", "an..14", "")]
        public string E0020 { get; set; }
        [ElementInfo(1, "INTERCHANGE SENDER", "M", "1", "", "")]
        public S002 S002 { get; set; }
        [ElementInfo(2, "INTERCHANGE RECIPIENT", "M", "1", "", "")]
        public S003 S003 { get; set; }
        [ElementInfo(3, "Action, coded", "M", "1", "an..3", "")]
        public string E0083 { get; set; }
        [ElementInfo(4, "Syntax error, coded", "C", "1", "an..3", "")]
        public string E0085 { get; set; }
        [ElementInfo(5, "Service segment tag, coded", "C", "1", "a3", "")]
        public string E0013 { get; set; }
        [ElementInfo(6, "DATA ELEMENT IDENTIFICATION", "C", "1", "", "")]
        public S011 S011 { get; set; }


    }
}