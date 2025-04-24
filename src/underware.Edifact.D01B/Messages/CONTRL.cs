using System.Linq;
using underware.Edi.Common.DocumentModel;
using underware.Edifact.D01B.Segments;
using underware.Edifact.Structures.S3.Segments;

namespace underware.Edifact.D01B.Messages
{
    public class CONTRL: Message
    {
        protected override BaseDocument GetBaseDocument()
        {
            var uci = Segments.OfType<UCI>().First();
            var ucm = Segments.OfType<UCM>().First();
            
            return new InterchangeAcknowledgement()
            {
                RefNo = UNH.MessageReferenceNumber,
                RefInterchangeRefNo = uci.E0020,
                RefInterchangeSender = uci.S002.E0004,
                RefInterchangeRecipient = uci.S003.E0010,
                RefInterchangeStatusCode = uci.E0083,
                RefMessageType = ucm.S009.E0065,
                RefMessageRefNo = ucm.E0062,
                RefMessageStatusCode = ucm.E0083
            };
        }
    }
}