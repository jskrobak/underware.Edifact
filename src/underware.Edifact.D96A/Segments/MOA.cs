using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D96A.Composites;

namespace underware.Edifact.D96A.Segments
{
	public class MOA : Segment
	{
		public MOA() : base("MOA", "Monetary amount")
		{
		}

		[ElementInfo(0, "MONETARY AMOUNT", "M", "1", "", "")]
		public C516 C516 { get; set; }


		public string Qualifier => C516.E5025;

		public decimal? Amount =>
			decimal.TryParse(C516?.E5004, NumberStyles.Any, CultureInfo.InvariantCulture, out var result) 
				? result 
				: (decimal?)null;
	}
}