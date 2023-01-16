using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class CAV : Segment
    {
        public CAV() : base("CAV", "Characteristic value") { }

        [ElementInfo(0, "CHARACTERISTIC VALUE", "M", "1", "", "")]
        public C889 C889 { get; set; }


    }
}