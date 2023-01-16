using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class ODI : Segment
    {
        public ODI() : base("ODI", "Origin and destination details") { }

        [ElementInfo(0, "Location name code", "C", "2", "an..25", "")]
        public string E3225 { get; set; }
        [ElementInfo(1, "Sequence position identifier", "C", "2", "an..10", "")]
        public string E1050 { get; set; }


    }
}