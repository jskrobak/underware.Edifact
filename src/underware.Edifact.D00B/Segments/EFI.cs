using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class EFI : Segment
    {
        public EFI() : base("EFI", "External file link identification") { }

        [ElementInfo(0, "FILE IDENTIFICATION", "M", "1", "", "")]
        public C077 C077 { get; set; }
        [ElementInfo(1, "FILE DETAILS", "C", "1", "", "")]
        public C099 C099 { get; set; }
        [ElementInfo(2, "Sequence position identifier", "C", "1", "an..10", "")]
        public string E1050 { get; set; }
        [ElementInfo(3, "File compression technique name", "C", "1", "an..35", "")]
        public string E9450 { get; set; }


    }
}