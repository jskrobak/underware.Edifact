using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class TDT : Segment
    {
        public TDT() : base("TDT", "Details of transport") { }

        [ElementInfo(0, "Transport stage code qualifier", "M", "1", "an..3", "")]
        public string E8051 { get; set; }
        [ElementInfo(1, "Means of transport journey identifier", "C", "1", "an..17", "")]
        public string E8028 { get; set; }
        [ElementInfo(2, "MODE OF TRANSPORT", "C", "1", "", "")]
        public C220 C220 { get; set; }
        [ElementInfo(3, "TRANSPORT MEANS", "C", "1", "", "")]
        public C228 C228 { get; set; }
        [ElementInfo(4, "CARRIER", "C", "1", "", "")]
        public C040 C040 { get; set; }
        [ElementInfo(5, "Transit direction indicator code", "C", "1", "an..3", "")]
        public string E8101 { get; set; }
        [ElementInfo(6, "EXCESS TRANSPORTATION INFORMATION", "C", "1", "", "")]
        public C401 C401 { get; set; }
        [ElementInfo(7, "TRANSPORT IDENTIFICATION", "C", "1", "", "")]
        public C222 C222 { get; set; }
        [ElementInfo(8, "Transport means ownership indicator code", "C", "1", "an..3", "")]
        public string E8281 { get; set; }


    }
}