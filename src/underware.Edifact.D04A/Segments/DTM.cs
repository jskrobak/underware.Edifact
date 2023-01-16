using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
    public class DTM : Segment
    {
        public DTM() : base("DTM", "Date/time/period") { }

        [ElementInfo(0, "DATE/TIME/PERIOD", "M", "1", "", "")]
        public C507 C507 { get; set; }

        public string Qualifier { get => C507.E2005; }

        public DateTime GetDateTime()
        {
            return C507.GetDateTime();
        }
    }
}