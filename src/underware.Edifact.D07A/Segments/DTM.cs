using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D07A.Composites;

namespace underware.Edifact.D07A.Segments
{
	public class DTM : Segment
	{
		public DTM() : base("DTM", "DATE/TIME/PERIOD")
		{
		}

		[ElementInfo(0, "DATE/TIME/PERIOD", "Mandatory", "", "", "")]
		public C507 C507 { get; set; }

		public string Qualifier { get => C507.E2005; }

		public DateTime GetDateTime()
		{
			return C507.GetDateTime();
		}
        
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