using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D01B.Composites;

namespace underware.Edifact.D01B.Segments
{
    public class QTY : Segment
    {
        public QTY() : base("QTY", "Quantity")
        {
        }

        [ElementInfo(0, "QUANTITY DETAILS", "M", "1", "", "")]
        public C186 C186 { get; set; }

        public string Qualifier => C186.E6063;
        public decimal Value => decimal.Parse(C186.E6060, CultureInfo.InvariantCulture);

        public string Unit
        {
            get => C186.E6411;
            set
            {
                if (C186 != null)
                    C186.E6411 = value;
            }
        }

    }
}