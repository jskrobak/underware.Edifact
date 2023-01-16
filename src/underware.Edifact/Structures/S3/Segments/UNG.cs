using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S3.Composites;

namespace underware.Edifact.Structures.S3.Segments
{
    public class UNG : Segment
    {
        public UNG() : base("UNG", "Group header") { }
        public UNG(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Functional group identification", "M", "1", "an..6", "")]
        public string E0038 { get; set; }
        [ElementInfo(1, "APPLICATION SENDER'S IDENTIFICATION", "M", "1", "", "")]
        public S006 S006 { get; set; }
        [ElementInfo(2, "APPLICATION RECIPIENT'S IDENTIFICATION", "M", "1", "", "")]
        public S007 S007 { get; set; }
        [ElementInfo(3, "DATE/TIME OF PREPARATION", "M", "1", "", "")]
        public S004 S004 { get; set; }
        [ElementInfo(4, "Functional group reference number", "M", "1", "an..14", "")]
        public string E0048 { get; set; }
        [ElementInfo(5, "Controlling agency", "M", "1", "an..2", "")]
        public string E0051 { get; set; }
        [ElementInfo(6, "MESSAGE VERSION", "M", "1", "", "")]
        public S008 S008 { get; set; }
        [ElementInfo(7, "Application password", "C", "1", "an..14", "")]
        public string E0058 { get; set; }


    }
}