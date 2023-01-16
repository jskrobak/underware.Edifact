using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;

namespace underware.Edifact.D96A.Segments
{
    public class IMD : Segment
    {
        public IMD() : base("IMD", "Item description") { }

        [ElementInfo(0, "Item description type, coded", "C", "1", "an..3", "")]
        public string E7077 { get; set; }
        [ElementInfo(1, "Item characteristic, coded", "C", "1", "an..3", "")]
        public string E7081 { get; set; }
        [ElementInfo(2, "ITEM DESCRIPTION", "C", "1", "", "")]
        public C273 C273 { get; set; }
        [ElementInfo(3, "Surface/layer indicator, coded", "C", "1", "an..3", "")]
        public string E7383 { get; set; }


    }
}