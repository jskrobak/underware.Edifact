using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01A.Composites;

namespace underware.Edifact.D01A.Segments
{
    public class NAA : Segment
    {
        public NAA() : base("NAA", "Name and address") { }

        [ElementInfo(0, "Party function code qualifier", "M", "1", "an..3", "")]
        public string E3035 { get; set; }
        [ElementInfo(1, "PARTY IDENTIFICATION DETAILS", "C", "1", "", "")]
        public E082 E082 { get; set; }
        [ElementInfo(2, "Name and address description", "C", "5", "an..35", "")]
        public string E3124 { get; set; }
        [ElementInfo(3, "PARTY NAME", "C", "1", "", "")]
        public E080 E080 { get; set; }
        [ElementInfo(4, "Street and number or post office box identifier", "C", "1", "an..35", "")]
        public string E3042 { get; set; }
        [ElementInfo(5, "City name", "C", "1", "an..35", "")]
        public string E3164 { get; set; }
        [ElementInfo(6, "Country sub-entity name code", "C", "1", "an..9", "")]
        public string E3229 { get; set; }
        [ElementInfo(7, "Postal identification code", "C", "1", "an..17", "")]
        public string E3251 { get; set; }
        [ElementInfo(8, "Country name code", "C", "1", "an..3", "")]
        public string E3207 { get; set; }


    }
}