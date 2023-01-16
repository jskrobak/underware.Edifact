using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UIB : Segment
    {
        public UIB() : base("UIB", "Interactive interchange header") { }
        public UIB(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "SYNTAX IDENTIFIER", "M", "1", "", "")]
        public S001 S001 { get; set; }
        [ElementInfo(1, "DIALOGUE REFERENCE", "C", "1", "", "")]
        public S302 S302 { get; set; }
        [ElementInfo(2, "TRANSACTION REFERENCE", "C", "1", "", "")]
        public S303 S303 { get; set; }
        [ElementInfo(3, "SCENARIO IDENTIFICATION", "C", "1", "", "")]
        public S018 S018 { get; set; }
        [ElementInfo(4, "DIALOGUE IDENTIFICATION", "C", "1", "", "")]
        public S305 S305 { get; set; }
        [ElementInfo(5, "INTERCHANGE SENDER", "C", "1", "", "")]
        public S002 S002 { get; set; }
        [ElementInfo(6, "INTERCHANGE RECIPIENT", "C", "1", "", "")]
        public S003 S003 { get; set; }
        [ElementInfo(7, "DATE AND/OR TIME OF INITIATION", "C", "1", "", "")]
        public S300 S300 { get; set; }
        [ElementInfo(8, "Duplicate Indicator", "C", "1", "a1", "")]
        public string E0325 { get; set; }
        [ElementInfo(9, "Test indicator", "C", "1", "n1", "")]
        public string E0035 { get; set; }


    }
}