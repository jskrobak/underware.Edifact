using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class ASD : Segment
    {
        public ASD() : base("ASD", "Service details") { }

        [ElementInfo(0, "ADDITIONAL SERVICE DETAILS", "M", "9", "", "")]
        public E959 E959 { get; set; }
        [ElementInfo(1, "DATE AND TIME INFORMATION", "C", "99", "", "")]
        public E013 E013 { get; set; }
        [ElementInfo(2, "Days of week set identifier", "C", "1", "an..7", "")]
        public string E2160 { get; set; }


    }
}