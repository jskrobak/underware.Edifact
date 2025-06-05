using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments;

public class MOA() : Segment("MOA", "MONETARY AMOUNT")
{
    [ElementInfo(0, "MONETARY AMOUNT", "Mandatory", "", "", "")]
    public C516 C516 { get; set; }

    public string Qualifier => C516.E5025;

    public decimal? Amount =>
        decimal.TryParse(C516?.E5004, NumberStyles.Any, CultureInfo.InvariantCulture, out var result)
            ? result
            : (decimal?)null;
}