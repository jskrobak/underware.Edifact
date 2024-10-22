using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D93A.Composites;

namespace underware.Edifact.D93A.Segments
{
    public class DTM : Segment
    {
        public DTM() : base("DTM", "Date/time/period")
        {
        }

        [ElementInfo(0, "DATE/TIME/PERIOD", "M", "1", "", "")]
        public C507 C507 { get; set; }

        public string Qualifier => C507?.E2005;
        public DateTime Date
        {
            get
            {
                var format = DateTimeFormat.Parse(C507.E2379);
                return C507.E2380.ParseDateTime(format);
            }
        }
    }
}