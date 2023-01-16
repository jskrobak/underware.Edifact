using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UIH : Segment
    {
        public UIH() : base("UIH", "Interactive message header") { }
        public UIH(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "INTERACTIVE MESSAGE IDENTIFIER", "M", "1", "", "")]
        public S306 S306 { get; set; }
        [ElementInfo(1, "Interactive message reference number", "C", "1", "an..35", "")]
        public string E0340 { get; set; }
        [ElementInfo(2, "DIALOGUE REFERENCE", "C", "1", "", "")]
        public S302 S302 { get; set; }
        [ElementInfo(3, "STATUS OF TRANSFER - INTERACTIVE", "C", "1", "", "")]
        public S301 S301 { get; set; }
        [ElementInfo(4, "DATE AND/OR TIME OF INITIATION", "C", "1", "", "")]
        public S300 S300 { get; set; }
        [ElementInfo(5, "Test indicator", "C", "1", "n1", "")]
        public string E0035 { get; set; }


    }
}