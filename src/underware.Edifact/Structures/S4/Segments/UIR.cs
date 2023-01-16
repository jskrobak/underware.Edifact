using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UIR : Segment
    {
        public UIR() : base("UIR", "Interactive status") { }
        public UIR(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Report function, coded", "M", "1", "an..3", "")]
        public string E0331 { get; set; }
        [ElementInfo(1, "REPORT REASON", "C", "9", "", "")]
        public S307 S307 { get; set; }
        [ElementInfo(2, "DIALOGUE REFERENCE", "C", "1", "", "")]
        public S302 S302 { get; set; }
        [ElementInfo(3, "DATE AND/OR TIME OF INITIATION", "C", "1", "", "")]
        public S300 S300 { get; set; }
        [ElementInfo(4, "Interactive message reference number", "C", "1", "an..35", "")]
        public string E0340 { get; set; }
        [ElementInfo(5, "Package reference number", "C", "1", "an..35", "")]
        public string E0800 { get; set; }


    }
}