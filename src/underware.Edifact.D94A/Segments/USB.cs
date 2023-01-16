using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D94A.Composites;

namespace underware.Edifact.D94A.Segments
{
    public class USB : Segment
    {
        public USB() : base("USB", "Secured data identification") { }
        public USB(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters) { }

        [ElementInfo(0, "Response type, coded", "M", "1", "an..3", "")]
        public string E0503 { get; set; }
        [ElementInfo(1, "SECURITY DATE AND TIME", "C", "1", "", "")]
        public S501 S501 { get; set; }
        [ElementInfo(2, "INTERCHANGE SENDER", "M", "1", "", "")]
        public S002 S002 { get; set; }
        [ElementInfo(3, "INTERCHANGE RECIPIENT", "M", "1", "", "")]
        public S003 S003 { get; set; }


    }

}