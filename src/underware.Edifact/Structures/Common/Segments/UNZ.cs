using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;

namespace underware.Edifact.Structures.Common.Segments
{
    public class UNZ : Segment
    {
        public UNZ() : base("UNZ", "Interchange trailer")
        {
            MessageCount = 0;
        }

        public UNZ(int msgCnt, string refNo) : base("UNZ", "Interchange trailer")
        {
            MessageCount = msgCnt;
            E0020 = refNo;
        }

        [ElementInfo(0, "Interchange control count", "M", "1", "n..6", "")]
        public string E0036 { get; set; }

        [ElementInfo(1, "Interchange control reference", "M", "1", "an..14", "")]
        public string E0020 { get; set; }

        public int MessageCount { get { return int.Parse(E0036); } set { E0036 = value.ToString(); } }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

