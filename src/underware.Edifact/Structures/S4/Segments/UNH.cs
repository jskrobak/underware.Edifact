using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Interfaces;
using underware.Edifact.Structures.S4.Composites;

namespace underware.Edifact.Structures.S4.Segments
{
    public class UNH : Segment, IUNH
    {
        public UNH() : base("UNH", "Interchange header")
        {
            Init();
        }

        public UNH(string segmentString) : base("UNH", "Interchange header")
        {
            Init();
            ParseSegment(CharSpec.Default, segmentString);
        }

        public UNH(string stringToFormat, params object[] parameters) : base(stringToFormat, parameters)
        {
            Init();
        }

        public UNH(string messageType, string version, string release, string agency, string association, string refNo) : base("UNH", "Interchange header")
        {
            Init();

            MessageType = messageType;
            Version = version;
            Release = release;
            ControllingAgency = agency;
            Association = association;
            MessageReferenceNumber = refNo;
        }

        private void Init()
        {
            S009 = new S009();
            S010 = new S010();
            S016 = new S016();
            S017 = new S017();
            S018 = new S018();
        }
              

        [ElementInfo(0, "Message reference number", "M", "1", "an..14", "")]
        public string E0062 { get; set; }
        [ElementInfo(1, "MESSAGE IDENTIFIER", "M", "1", "", "")]
        public S009 S009 { get; set; }
        [ElementInfo(2, "Common access reference", "C", "1", "an..35", "")]
        public string E0068 { get; set; }
        [ElementInfo(3, "STATUS OF THE TRANSFER", "C", "1", "", "")]
        public S010 S010 { get; set; }
        [ElementInfo(4, "MESSAGE SUBSET IDENTIFICATION", "C", "1", "", "")]
        public S016 S016 { get; set; }
        [ElementInfo(5, "MESSAGE IMPLEMENTATION GUIDELINE IDENTIFICATION", "C", "1", "", "")]
        public S017 S017 { get; set; }
        [ElementInfo(6, "SCENARIO IDENTIFICATION", "C", "1", "", "")]
        public S018 S018 { get; set; }


        public string MessageType { get => S009.E0065; set => S009.E0065 = value; }
        public string Version { get => S009.E0052; set => S009.E0052 = value; }
        public string Release { get => S009.E0054; set => S009.E0054 = value; }
        public string ControllingAgency { get => S009.E0051; set => S009.E0051 = value; }
        public string Association { get => S009.E0057; set => S009.E0057 = value; }
        public string MessageReferenceNumber { get => E0062; set => E0062 = value; }
    }
}