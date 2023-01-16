using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact;
using underware.Edifact.Attributes;

namespace underware.Odette.V3.Messages.Segments
{
    public class MID : Segment
    {
        [ElementInfo(1, "Document Number", "M", "1", "an..17", "")]
        public string E1004 { get; set; }


        [ElementInfo(2, "Document Date, coded", "M", "1", "n6", "")]
        public string E2007 { get; set; }


        public MID() : base("MID", "Message Identification")
        {

        }

        
    }
}
