using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;
using underware.Edifact.Structures.Common.Segments.Interfaces;

namespace underware.Edifact.D96A.Segments
{
    public class DTM : Segment, IDTM
    {
        public DTM() : base("DTM", "Date/time/period") { }

        [ElementInfo(0, "DATE/TIME/PERIOD", "M", "1", "", "")]
        public C507 C507 { get; set; }

        public string Qualifier => C507.E2005;
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