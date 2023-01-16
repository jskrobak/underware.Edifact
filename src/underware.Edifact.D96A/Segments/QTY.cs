using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;
using underware.Edifact.Structures.Common.Segments.Interfaces;

namespace underware.Edifact.D96A.Segments
{
    public class QTY : Segment, IQTY
    {
        public QTY() : base("QTY", "Quantity") { }

        [ElementInfo(0, "QUANTITY DETAILS", "M", "1", "", "")]
        public C186 C186 { get; set; }

        public string Qualifier => C186.E6063;

        public string Unit => C186.E6411;

        public decimal Value => decimal.Parse(C186.E6060, CultureInfo.InvariantCulture);
    }
}