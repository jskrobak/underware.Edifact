using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using underware.Edifact.Attributes;
using underware.Edifact.Structures.Common.Composites;

namespace underware.Edifact.Structures.Common.Segments
{
    public class UNB : Segment
    {
        public UNB() : base("UNB", "Interchange header")
        {
            S001 = new S001();
            S002 = new S002();
            S003 = new S003();
            S004 = new S004();
        }

        public UNB(string segmentString) : base("UNB", "Interchange header")
        {
            ParseSegment(CharSpec.Default, segmentString);
        }

        public UNB(Syntax syntax, Party sender, Party receiver, DateTime created, string refNo, string appRef, bool isTest) : base("UNB", "Interchange header")
        {

            S001 = syntax.ToS001();
            S002 = sender.Sender;
            S003 = receiver.Receiver;
            S004 = new S004()
            {
                E0017 = string.Format("{0:yyMMdd}", created),
                E0019 = string.Format("{0:HHmm}", created),
            };

            E0020 = refNo;
            E0026 = appRef;
            E0035 = isTest ? "1" : "";
        }

        public Syntax Syntax
        {
            get
            {
                return new Syntax(S001);
            }
        }

        public Party Sender { get => S002.ToParty(); }
        public Party Receiver { get => S003.ToParty(); }

        public string RefNo { get => E0020; }

        public DateTime Created
        {
            get
            {
                DateTime dt = DateTime.MinValue;
                DateTime.TryParseExact(string.Format("{0}{1}", S004.E0017, S004.E0019), "yyMMddHHmm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);

                return dt;
            }
        }

        [ElementInfo(0, "SYNTAX IDENTIFIER")]
        public S001 S001 { get; set; }

        [ElementInfo(1, "INTERCHANGE SENDER")]
        public S002 S002 { get; set; }

        [ElementInfo(3, "INTERCHANGE RECIPIENT")]
        public S003 S003 { get; set; }

        [ElementInfo(4, "DATE / TIME OF PREPARATION")]
        public S004 S004 { get; set; }

        [ElementInfo(5, "Interchange control reference", "M", "1", "an..14", "")]
        public string E0020 { get; set; }

        [ElementInfo(6, "RECIPIENT'S REFERENCE, PASSWORD")]
        public S005 S005 { get; set; }

        [ElementInfo(7, "Application reference", "C", "1", "an..14", "")]
        public string E0026 { get; set; }

        [ElementInfo(8, "Processing priority code", "C", "1", "a1", "")]
        public string E0029 { get; set; }


        [ElementInfo(9, "Acknowledgement request", "C", "1", "n1", "")]
        public string E0031 { get; set; }

        [ElementInfo(10, "Communications agreement ID", "C", "1", "an..35", "")]
        public string E0032 { get; set; }

        [ElementInfo(11, "Test indicator", "C", "1", "n1", "")]
        public string E0035 { get; set; }
    }
}
