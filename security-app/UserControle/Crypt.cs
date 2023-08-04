using System;
using System.Security.Cryptography;

namespace security_app
{
    static class Crypt
    {
        static public string DecrypterPassWord(string password)
        {
            CspParameters cspParameters = new CspParameters();
            RSAParameters privateKeys;

            using (var rsa = new RSACryptoServiceProvider(cspParameters))
            {
                rsa.FromXmlString(MyLib.pr);
                privateKeys = rsa.ExportParameters(true);
                rsa.Clear();
            }

            return MyLib.DecryptAssym(Convert.FromBase64String(password), privateKeys);
        }

        static public string CrypterMotDePass(string password)
        {
            CspParameters cspParameters = new CspParameters();
            RSAParameters publicKeys;

            using (var rsa = new RSACryptoServiceProvider(cspParameters))
            {
                rsa.FromXmlString(MyLib.pu);
                publicKeys = rsa.ExportParameters(false);
                rsa.Clear();
            }

            return Convert.ToBase64String(MyLib.EncryptAssym(password, publicKeys));
        }
    }
}
