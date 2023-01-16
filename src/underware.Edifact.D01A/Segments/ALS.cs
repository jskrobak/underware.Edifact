using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class ALS : Segment
    {
        public ALS() : base("ALS", "Additional location information") { }

        [ElementInfo(0, "Location function code qualifier", "M", "1", "an..3", "")]
        public string E3227 { get; set; }
        [ElementInfo(1, "LOCATION", "M", "99", "", "")]
        public E975 E975 { get; set; }
        [ElementInfo(2, "Latitude value", "C", "1", "an..10", "")]
        public string E6000 { get; set; }
        [ElementInfo(3, "Longitude value", "C", "1", "an..11", "")]
        public string E6002 { get; set; }


    }
}