using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.D04A.Composites
{
    public class C507
    {
        [ElementInfo(0, "Date or time or period function code qualifier", "M", "", "an..3", "")]
        public string E2005 { get; set; }
        [ElementInfo(1, "Date or time or period text", "C", "", "an..35", "")]
        public string E2380 { get; set; }
        [ElementInfo(2, "Date or time or period format code", "C", "", "an..3", "")]
        public string E2379 { get; set; }

        public DateTime GetDateTime()
        {
            return underware.Edifact.Extensions.ParseDateTime(E2380, DateTimeFormat.GetFromEdi(E2379));
        }
    }
}