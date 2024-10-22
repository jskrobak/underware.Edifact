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
                var format = DateTimeFormat.Parse(C507.E2379);
                return C507.E2380.ParseDateTime(format);
            }
        }
        
        public DateTime? NullableDate
        {
            get
            {
                var format = DateTimeFormat.Parse(C507.E2379);
                var date = C507.E2380.ParseDateTime(format);
                return date == DateTime.MinValue ? (DateTime?)null : date;
            }
        }

        public string Qualifier => C507.E2005;
    }
}