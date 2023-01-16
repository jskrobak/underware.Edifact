using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using underware.Edifact.D01B;
using underware.Edifact.Security;
using underware.Edifact.Xml;

namespace underware.Edifact.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> list = CharSpec.Default.SplitComponents("Novaservis Ferro Group Capital Social: 200.000 LEI:::");


            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            Encoding cp1250 = Encoding.GetEncoding(1250);

            Interchange itr = Interchange.FromFile(@"Samples\D96A_INVOIC.txt", cp1250);
            //SegmentGroup sg = itr.Messages[0].CreateTree();
            //var xml = sg.ToXml();
            //Console.WriteLine(xml);


            //string json = Newtonsoft.Json.JsonConvert.SerializeObject(sg);

            //Interchange autack = Interchange.Create(Syntax.UNOD3, itr.UNB.Receiver, itr.UNB.Sender, "1245", "AUTACK", false, itr.Encoding);
            //autack.Add(Message.Create(new CodeLists.MessageIdentifier("AUTACK", "D", "94A", "UN"), "124500001"));
            //Console.WriteLine(itr);

            //Sign(cp1250, itr);

            Console.WriteLine(Templates.TAX("7", "VAT", 0m, "E").ToString());
            Console.ReadLine();
        }

       

        static void Sign(Encoding enc, Interchange itr)
        {
            string certFile = @"c:\Data\Doc\EDIData\Signature\privatekey_dolezal_2019.pfx";
            string password = "TplDuaZNvpCVnihCapbT";

            itr.Sign(enc, certFile, password);
            Console.WriteLine(itr.Messages[0].CreateTree().ToXml());
            // itr.Sign(cert, privateKey, HashAlgorithm.SHA256);

            Console.WriteLine(itr);

            Console.WriteLine();

            X509Certificate2Collection certs = new X509Certificate2Collection();
            certs.Add(new X509Certificate2(@"c:\Data\Doc\EDIData\Signature\privatekey_dolezal_2019.cer"));

            Interchange autack = itr.VerifyAndCreate_AUTACK_D94A(Encoding.GetEncoding(1250), certs, "000001");
            //autack.Sign(certFile, password);

            Console.WriteLine(autack);

            // Console.WriteLine(autack.Messages[0].CreateTree().ToXml());
        }
    }
}
