using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00B.Composites;

namespace underware.Edifact.D00B.Segments
{
    public class ITD : Segment
    {
        public ITD() : base("ITD", "Information type data") { }

        [ElementInfo(0, "Information category code", "C", "1", "an..3", "")]
        public string E9601 { get; set; }
        [ElementInfo(1, "Language name code", "C", "1", "an..3", "")]
        public string E3453 { get; set; }
        [ElementInfo(2, "Information detail identifier", "C", "10", "an..17", "")]
        public string E9603 { get; set; }
        [ElementInfo(3, "Data format description code", "C", "1", "an..3", "")]
        public string E1503 { get; set; }


    }
}