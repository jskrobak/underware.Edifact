using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class HDI : Segment
    {
        public HDI() : base("HDI", "Hardware device information") { }

        [ElementInfo(0, "Communication address identifier", "C", "1", "an..512", "")]
        public string E3148 { get; set; }
        [ElementInfo(1, "Department or employee name code", "C", "1", "an..17", "")]
        public string E3413 { get; set; }
        [ElementInfo(2, "Computer environment name code", "C", "1", "an..3", "")]
        public string E1511 { get; set; }
        [ElementInfo(3, "ATTRIBUTE INFORMATION", "C", "9", "", "")]
        public E003 E003 { get; set; }


    }
}