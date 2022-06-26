using PgpCore;
using System.Security.Cryptography;
using System.Text;

namespace NoPassword
{
    public static class EncryptionHelper
    {
        public static Stream EncryptToken(MemoryStream pgpKey, MemoryStream token)
        {
            PGP prettyGoodPrivacy = new();
            MemoryStream encryptedMessage = new();

            prettyGoodPrivacy.EncryptStream(token, encryptedMessage, pgpKey, true, true);

            return encryptedMessage;
        }

        public static MemoryStream TokenGenerator()
        {
            byte[] salt = new byte[128 / 8];
            RandomNumberGenerator.Create().GetNonZeroBytes(salt);

            var contents = Convert.ToBase64String(SHA512.Create().ComputeHash(
                    Encoding.Default.GetBytes(Convert.ToBase64String(salt))));

            byte[] byteArray = Encoding.UTF8.GetBytes(contents);
            MemoryStream stream = new(byteArray);

            return stream;
        }
    }
}