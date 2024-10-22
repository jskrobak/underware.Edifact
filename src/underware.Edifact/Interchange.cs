using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.Structures.Common.Segments;
using underware.Edifact.Xml;

namespace underware.Edifact
{
    public class Interchange : IEdiInterchange, IXmlExportable

    {
        private MessageList _messages;
        private List<Segment> _header;
        private List<Segment> _trailer;
        private Syntax _syntax;
        private CharSpec _charSpec;

        public Interchange(CharSpec spec, Syntax syntax)
        {
            _charSpec = spec;
            _syntax = syntax;
            _messages = new MessageList(this);
            _header = new List<Segment>();
            _trailer = new List<Segment>();

        }

        public Interchange(CharSpec spec, Syntax syntax, Party sender, Party receiver, string refNo, string appRef,
            bool isTest)
        {
            _charSpec = spec;
            _syntax = syntax;
            _messages = new MessageList(this);
            _header = new List<Segment>();
            _trailer = new List<Segment>();

            this.Header.Add(new UNB(syntax, sender, receiver, DateTime.Now, refNo, appRef, isTest));
            this.Trailer.Add(new UNZ(0, refNo));
        }

        public Syntax Syntax
        {
            get { return _syntax; }
        }

        public CharSpec CharSpec
        {
            get { return _charSpec; }
        }

        //public Encoding Encoding { get { return _encoding; } }
        public List<Segment> Header
        {
            get { return _header; }
        }

        public List<Segment> Trailer
        {
            get { return _trailer; }
        }

        public MessageList Messages
        {
            get { return _messages; }
        }

        public UNB UNB
        {
            get => Header.Where(s => s.Name == "UNB").First() as UNB;
        }

        public UNZ UNZ
        {
            get => Trailer.Where(s => s.Name == "UNZ").First() as UNZ;
        }

        public override string ToString()
        {
            return ToString(CharSpec.Default);
        }

        public XDocument ToXml(Encoding outEnc)
        {
            var xDoc = new XDocument(new XElement("Interchange", Messages.Select(m => m.Root.ToXml())));

            using var ms = new MemoryStream();

            // Create an XML writer with UTF-8 encoding
            var settings = new XmlWriterSettings
            {
                Encoding = outEnc, // false for no BOM
                Indent = true // optional: for pretty formatting
            };

            using var xmlWriter = XmlWriter.Create(ms, settings);

            // Write the XML document to the memory stream with UTF-8 encoding
            xDoc.WriteTo(xmlWriter);


            // Reset the memory stream position to the beginning
            ms.Position = 0;

            // Load the XML data from the memory stream as UTF-8 encoded
            return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
        }

        public string ToString(CharSpec charSpec)
        {
            UNZ.MessageCount = Messages.Count;

            var list = new List<string> { charSpec.JoinSegments(Header) };
            list.AddRange(Messages.Select(msg => msg.ToString(charSpec)));

            list.Add(charSpec.JoinSegments(Trailer));

            return string.Concat(charSpec, charSpec.JoinSegments(list), charSpec.SegmentSeparator);
        }


        public static Interchange FromFile(string filePath, Encoding enc)
        {
            return Parse(File.ReadAllText(filePath, enc));
        }

        public static Interchange Parse(string contentString)
        {
            string content = contentString.Replace("\r", "");
            content = content.Replace("\n", "");

            CharSpec spec = CharSpec.GetFromUNAOrDefault(content);

            List<string> segmentBuffer = null;
            List<string> allSegments = spec.SplitSegments(content);

            //UNB
            string unbStr = allSegments.Where(s => s.StartsWith("UNB")).FirstOrDefault();

            if (String.IsNullOrEmpty(unbStr))
                throw new Exception("Interchange must have at least one UNB segment!");

            UNB unb = Segment.Parse(spec, unbStr) as UNB;


            //UNB
            string unzStr = allSegments.Where(s => s.StartsWith("UNZ")).FirstOrDefault();

            if (String.IsNullOrEmpty(unzStr))
                throw new Exception("Interchange must have at least one UNZ segment!");

            UNZ unz = Segment.Parse(spec, unzStr) as UNZ;

            Interchange itr = new Interchange(spec, unb.Syntax);
            itr.Header.Add(unb);
            itr.Trailer.Add(unz);

            string[] toSkip = new string[] { "UNA", "UNB", "UNZ" };

            foreach (string segmentString in allSegments.Where(s =>
                         !string.IsNullOrEmpty(s) && s.Length > 2 && !toSkip.Contains(s.Substring(0, 3))))
            {
                string name = segmentString.Substring(0, 3);

                if (name == "UNH")
                {
                    if (segmentBuffer != null)
                        itr.Messages.Add(Message.Parse(spec, unb.Syntax.Version, segmentBuffer));

                    segmentBuffer = new List<string>();
                    segmentBuffer.Add(segmentString);
                }
                else
                {
                    segmentBuffer.Add(segmentString);
                }

            }

            if (segmentBuffer != null)
                itr.Messages.Add(Message.Parse(spec, unb.Syntax.Version, segmentBuffer));

            return itr;
        }

        public string Sender
        {
            get { return UNB.Sender.Identifier; }
        }

        public string Receiver
        {
            get { return UNB.Receiver.Identifier; }
        }
        
        public string Format 
        {
            get
            {
                if (Messages.Count == 0)
                {
                    throw new EmptyInterchangeException();
                }

                var unh = Messages.FirstOrDefault().UNH;


                return $"EDIFACT.{unh.Release}.{unh.Version}.{unh.MessageType}";

            }
            
        }

        public string RefNo => UNB.RefNo;
        public DateTime Created => UNB.Created;

        public IEnumerable<IDocument> Documents => Messages;

        public string TextContent
        {
            get { return ToString(); }
        }
    }
}
