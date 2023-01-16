using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using underware.Edifact.Structures.S3.Segments;

namespace underware.Edifact.Security.Signers
{
    
    public class S3Signer : Signer
    {
        public override Filter Filter => Filter.GetFilter(FilterType.HEXADECIMAL);

        public override void AddSecurityHeader(Message msg, HashAlgorithm hashAlgorithm, X509Certificate cert)
        {
            
            DateTime now = DateTime.Now;

            string date = DateTime.Now.ToString("yyyyMMdd");
            string time = DateTime.Now.ToString("HHmmss");

            //ush
            Segment USH = new USH("USH+94W+1+01+1+1+{0}+2+1+++{1}+1:{2:yyyyMMdd}:{2:HHmmss}:{3}", 
                                        Filter.Code,  msg.UNH.MessageReferenceNumber, now, now.SummerWinter());

            //USA1
            Segment USA = new USA("USA+1:0:1:{0}:1", (int)hashAlgorithm);

            //USC
            Segment USC = new USC("USC+{0}", cert.SerialNumber.ToByteArray().ToHexString());

            msg.Segments.Insert(0, USC);
            msg.Segments.Insert(0, USA);
            msg.Segments.Insert(0, USH);
        }

        public override void AddSecurityTrailer(Message msg, byte[] signature)
        {
            Segment USR = new USR("USR+{0}", Filter.Encode(signature));
            msg.Segments.Add(USR);

            Segment UST = new UST("UST+01");
            msg.Segments.Add(UST);

            msg.UNT.SegmentsCount = msg.AllSegments.Count;
        }
    }
}
