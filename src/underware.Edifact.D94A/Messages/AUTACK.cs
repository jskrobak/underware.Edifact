using System;
using System.Collections.Generic;
using System.Text;
using underware.Edifact.Structures.S3.Segments;
using underware.Edifact.D94A.Segments;
using underware.Edifact.Security;

namespace underware.Edifact.D94A.Messages
{
    public class AUTACK(string refNo) 
        : Message(3, "AUTACK", "D", "94A", "UN", "", refNo)
    {

        public static AUTACK Create(string refNo, string sender, string receiver, SignatureVerificationResult result)

        {
            var autack = new AUTACK(refNo);
            
            autack.Segments.Add(new USH("USH+94W+5+00++{0}+2", result.Signature.SignatureFilter));
            autack.Segments.Add(new USB("USB+1+1:{0:yyyyMMdd}:{0:HHmmss}+{1}+{2}", result.Created, sender, receiver));
            autack.Segments.Add(new USX("USX+{0}+++++{1}++5:{2:yyyyMMdd}:{2:HHmmss}:{3}", result.Signature.InterchangeRefNo,
                result.Signature.MessageRefNo, result.Created, result.Created.SummerWinter()));
            autack.Segments.Add(new USY("USY+01+{0}+{1}", result.SignedDataSHA1Hash.ToHexString(), result.AutackCode));

            return autack;
        }
    }
}
