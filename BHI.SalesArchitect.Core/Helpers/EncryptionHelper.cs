using System.Security.Cryptography;
using System.Text;

namespace BHI.SalesArchitect.Core.Helpers
{
    public class EncryptionHelper
    {
        public static string GenerateRandomKey(int keyLength)
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyz";
            char[] chars = new char[keyLength];

            for (int index = 0; index < keyLength; index++)
            {
                chars[index] = allowedChars[GetRandomNumber(0, allowedChars.Length)];
            }
            return new string(chars);
        }

        private static int GetRandomNumber(int minValue, int maxValue)
        {
            Random random = new(Guid.NewGuid().GetHashCode());
            int randomIndex = random.Next(minValue, maxValue);
            return randomIndex;
        }

        public static string GetSHA1(string str)
        {
            SHA1 sha1 = SHA1.Create();
            ASCIIEncoding encoding = new();
            StringBuilder sb = new();
            byte[] stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
