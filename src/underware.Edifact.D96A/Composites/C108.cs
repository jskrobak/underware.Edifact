using System;
using System.Collections.Generic;
using System.Text;
using underware.Edi.Common;
using underware.Edifact.Attributes;

namespace underware.Edifact.D96A.Composites
{
	public class C108
	{
		[ElementInfo(0, "Free text", "M", "", "an..70", "")]
		public string E4440 { get; set; }

		[ElementInfo(1, "Free text", "C", "", "an..70", "")]
		public string E4440_0 { get; set; }

		[ElementInfo(2, "Free text", "C", "", "an..70", "")]
		public string E4440_1 { get; set; }

		[ElementInfo(3, "Free text", "C", "", "an..70", "")]
		public string E4440_2 { get; set; }

		[ElementInfo(4, "Free text", "C", "", "an..70", "")]
		public string E4440_3 { get; set; }

		public string Text
		{
			get => string.Concat(E4440, E4440_0, E4440_1, E4440_2, E4440_3);
			set
			{
				var chunks = value.SplitToChunks(70, 5);
				E4440 = chunks[0];
				E4440_0= chunks[1];
				E4440_1= chunks[2];
				E4440_2= chunks[3];
				E4440_3= chunks[4];
			}
		}

		
	}
}