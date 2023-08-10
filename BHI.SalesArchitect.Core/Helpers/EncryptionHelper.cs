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
    }
}
