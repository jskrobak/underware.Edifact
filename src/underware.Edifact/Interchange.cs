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
            _header = [];
            _trailer = [];

        }

        public Interchange(CharSpec spec, Syntax syntax, Party sender, Party receiver, string refNo, string appRef,
            bool isTest)
        {
            _charSpec = spec;
            _syntax = syntax;
            _messages = new MessageList(this);
            _header = [];
            _trailer = [];

            this.Header.Add(new UNB(syntax, sender, receiver, DateTime.Now, refNo, appRef, isTest));
            this.Trailer.Add(new UNZ(0, refNo));
        }

        public Syntax Syntax => _syntax;

        public CharSpec CharSpec => _charSpec;

        //public Encoding Encoding { get { return _encoding; } }
        public List<Segment> Header => _header;

        public List<Segment> Trailer => _trailer;

        public MessageList Messages => _messages;

        public UNB UNB => Header.First(s => s.Name == "UNB") as UNB;

        public UNZ UNZ => Trailer.First(s => s.Name == "UNZ") as UNZ;

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
            var content = contentString.Replace("\r", "");
            content = content.Replace("\n", "");

            var spec = CharSpec.GetFromUNAOrDefault(content);

            List<string> segmentBuffer = null;
            var allSegments = spec.SplitSegments(content);

            //UNB
            var unbStr = allSegments.FirstOrDefault(s => s.StartsWith("UNB"));

            if (string.IsNullOrEmpty(unbStr))
                throw new Exception("Interchange must have at least one UNB segment!");

            var unb = Segment.Parse(spec, unbStr) as UNB;


            //UNB
            var unzStr = allSegments.FirstOrDefault(s => s.StartsWith("UNZ"));

            if (string.IsNullOrEmpty(unzStr))
                throw new Exception("Interchange must have at least one UNZ segment!");

            var unz = Segment.Parse(spec, unzStr) as UNZ;

            var itr = new Interchange(spec, unb.Syntax);
            itr.Header.Add(unb);
            itr.Trailer.Add(unz);

            string[] toSkip = ["UNA", "UNB", "UNZ"];

            foreach (var segmentString in allSegments.Where(s =>
                         !string.IsNullOrEmpty(s) && s.Length > 2 && !toSkip.Contains(s[..3])))
            {
                var name = segmentString[..3];

                if (name == "UNH")
                {
                    if (segmentBuffer != null)
                        itr.Messages.Add(Message.Parse(spec, unb.Syntax.Version, segmentBuffer));

                    segmentBuffer = [segmentString];
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

        public string Sender => UNB.Sender.Identifier;

        public string Receiver => UNB.Receiver.Identifier;

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
        public DateTime? Created => UNB.Created;

        public IEnumerable<IDocument> Documents => Messages;

        public string TextContent => ToString();
    }
}
