using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D04A.Composites;

namespace underware.Edifact.D04A.Segments
{
	public class MOA : Segment
	{
		public MOA() : base("MOA", "Monetary amount")
		{
		}

		[ElementInfo(0, "MONETARY AMOUNT", "M", "1", "", "")]
		public C516 C516 { get; set; }


	}
}