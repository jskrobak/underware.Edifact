using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.S3.Composites
{
    public class S502
    {
        [ElementInfo(0, "Use of algorithm, coded", "M", "", "an..3", "")]
        public string E0523 { get; set; }
        [ElementInfo(1, "Cryptographic mode of operation, coded", "C", "", "an..3", "")]
        public string E0525 { get; set; }
        [ElementInfo(2, "Mode of operation code list identifier", "C", "", "an..3", "")]
        public string E0533 { get; set; }
        [ElementInfo(3, "Algorithm, coded", "C", "", "an..3", "")]
        public string E0527 { get; set; }
        [ElementInfo(4, "Algorithm code list identifier", "C", "", "an..3", "")]
        public string E0529 { get; set; }
        [ElementInfo(5, "Padding mechanism, coded", "C", "", "an..3", "")]
        public string E0591 { get; set; }
        [ElementInfo(6, "Padding mechanism code list identifier", "C", "", "an..3", "")]
        public string E0601 { get; set; }

    }
}