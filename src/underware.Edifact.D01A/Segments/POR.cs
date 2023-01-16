using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class POR : Segment
    {
        public POR() : base("POR", "Location and/or related time information") { }

        [ElementInfo(0, "LOCATION IDENTIFICATION", "M", "1", "", "")]
        public E517 E517 { get; set; }
        [ElementInfo(1, "RELATED TIME INFORMATION", "C", "2", "", "")]
        public E362 E362 { get; set; }
        [ElementInfo(2, "POSITION", "C", "2", "", "")]
        public E992 E992 { get; set; }
        [ElementInfo(3, "Location function code qualifier", "C", "1", "an..3", "")]
        public string E3227 { get; set; }
        [ElementInfo(4, "Sequence position identifier", "C", "1", "an..10", "")]
        public string E1050 { get; set; }


    }
}