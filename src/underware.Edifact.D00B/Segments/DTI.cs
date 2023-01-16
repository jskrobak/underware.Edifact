using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class DTI : Segment
    {
        public DTI() : base("DTI", "Date and time information") { }

        [ElementInfo(0, "DATE AND TIME INFORMATION", "M", "9", "", "")]
        public E013 E013 { get; set; }
        [ElementInfo(1, "TIME REFERENCE DETAILS", "C", "99", "", "")]
        public E014 E014 { get; set; }


    }
}