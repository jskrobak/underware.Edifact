
using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.D00A.Composites;

namespace underware.Edifact.D00A.Segments
{
    public class MSD : Segment
    {
        public MSD() : base("MSD", "Message action details"){}

				[ElementInfo(0, "MESSAGE PROCESSING DETAILS", "C", "1", "", "" )]
public E972 E972 { get; set; }
		[ElementInfo(1, "Response type code", "C", "5", "an..3", "" )]
public string E4343 { get; set; }
		[ElementInfo(2, "OBJECT IDENTIFICATION", "C", "5", "", "" )]
public E206 E206 { get; set; }

		
    }
}