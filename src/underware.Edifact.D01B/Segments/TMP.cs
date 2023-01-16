using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class TMP : Segment
    {
        public TMP() : base("TMP", "Temperature") { }

        [ElementInfo(0, "Temperature type code qualifier", "M", "1", "an..3", "")]
        public string E6245 { get; set; }
        [ElementInfo(1, "TEMPERATURE SETTING", "C", "1", "", "")]
        public C239 C239 { get; set; }


    }
}