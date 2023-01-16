using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UNO : Segment
    {
        public UNO() : base("UNO", "Object header") { }
        public UNO(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Package reference number", "M", "1", "an..35", "")]
        public string E0800 { get; set; }
        [ElementInfo(1, "REFERENCE IDENTIFICATION", "M", "99", "", "")]
        public S020 S020 { get; set; }
        [ElementInfo(2, "OBJECT TYPE IDENTIFICATION", "M", "99", "", "")]
        public S021 S021 { get; set; }
        [ElementInfo(3, "STATUS OF THE OBJECT", "M", "1", "", "")]
        public S022 S022 { get; set; }
        [ElementInfo(4, "DIALOGUE REFERENCE", "C", "1", "", "")]
        public S302 S302 { get; set; }
        [ElementInfo(5, "STATUS OF TRANSFER - INTERACTIVE", "C", "1", "", "")]
        public S301 S301 { get; set; }
        [ElementInfo(6, "DATE AND/OR TIME OF INITIATION", "C", "1", "", "")]
        public S300 S300 { get; set; }
        [ElementInfo(7, "Test indicator", "C", "1", "n1", "")]
        public string E0035 { get; set; }


    }
}