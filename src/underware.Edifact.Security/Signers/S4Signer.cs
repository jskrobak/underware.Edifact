using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using System.Linq;
using underware.Edifact.Structures.S4.Segments;

namespace underware.Edifact.Security.Signers
{
    public class S4Signer : Signer
    {
        public override Filter Filter => Filter.GetFilter(FilterType.BASE64);

        public override void AddSecurityHeader(Message msg, HashAlgorithm hashAlgorithm, X509Certificate cert)
        {
            //base.AddSecurityHeader();

            string securityServiceCode = "1";

            string date = DateTime.Now.ToString("yyyyMMdd");
            string time = DateTime.Now.ToString("HHmmss");

            CharSpec chars = msg.Interchange.CharSpec;

            //ush
            Segment USH = new UNH("USH+{0}+01+1+1+{1}+2+1+1::{2}:2*2::{3}:2++5:{4}:{5}:{6}",
                                                securityServiceCode,
                                                Filter.Code,
                                                msg.Interchange.UNB.Sender.Identifier,
                                                msg.Interchange.UNB.Receiver.Identifier,
                                                date,
                                                time,
                                                DateTime.Now.SummerWinter());

            //USA1
            Segment USA1 = new USA("USA+1:::{0}:1", (int)hashAlgorithm);

            //USC
            Segment USC = new USC("USC+{0}+4::{1}:ZZZ+3",
                                                cert.SerialNumber.LongValue.ToString("X"),
                                                Filter.Encode(cert.IssuerDN.GetEncoded()).EDIEncode());

            //USA2
            Segment USA2 = new USA("USA+6:16:1:10:1:16:1");

            msg.Segments.Insert(0, USA2);
            msg.Segments.Insert(0, USC);
            msg.Segments.Insert(0, USA1);
            msg.Segments.Insert(0, USH);
        }

        public override void AddSecurityTrailer(Message msg, byte[] signature)
        {
            Segment USR = new USR("USR+1:{0}", Filter.Encode(signature).EDIEncode());
            msg.Segments.Add(USR);

            Segment UST = new UST("UST+01+6");
            msg.Segments.Add(UST);

            msg.UNT.SegmentsCount = msg.AllSegments.Count;
        }

    }
}
