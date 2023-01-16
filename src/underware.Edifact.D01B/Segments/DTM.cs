using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class DTM : Segment
    {
        public DTM() : base("DTM", "Date/time/period") { }
               

        [ElementInfo(0, "DATE/TIME/PERIOD", "M", "1", "", "")]
        public C507 C507 { get; set; }

        public DateTime Date
        {
            get
            {
                DateTimeFormat format = DateTimeFormat.GetFromEdi(C507.E2379);
                return C507.E2380.ParseDateTime(format);
            }
        }

    }
}