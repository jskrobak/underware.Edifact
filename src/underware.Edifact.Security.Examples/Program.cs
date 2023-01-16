// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;
using System.Text;
using underware.Edifact;
using underware.Edifact.Security;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

//Verify signature and create AUTACK message
SignAndVerify();

static void SignAndVerify()
{
    string filePath = Path.Join("Samples", "D96A_INVOIC.txt");  //Invoice interchange to sign
    string pfxFile = Path.Join("Samples", "jskrobak.pfx");      //PKCS12 file with private key - used for signing
    string pfxPassword = "xxxx";                                //private key password
    
    string certFile= Path.Join("Samples", "jskrobak.crt");      //Certificate with public key - used for verification
    
    
    //choose encoding. You can use ASCII, UTF-8, whatever
    Encoding enc = Encoding.GetEncoding(1250);

    //Load interchange from file
    Interchange itr = Interchange.FromFile(filePath, enc);

    //Sign interchange
    itr.Sign(enc, pfxFile, pfxPassword);
    
    Console.WriteLine(itr);

    Console.WriteLine();

    
    //verify signature
    Interchange autack = itr.VerifyAndCreate_AUTACK_D94A(Encoding.GetEncoding(1250),
        new X509Certificate2Collection(new X509Certificate2(certFile)), 
        "000001");
    
    autack.Sign(enc, pfxFile, pfxPassword);

    Console.WriteLine(autack);
}