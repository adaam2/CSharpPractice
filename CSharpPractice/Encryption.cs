using System;
using System.Security.Cryptography;
using System.Text;

namespace CSharpPractice
{
    class Encryption
    {
        public Encryption()
        {
            // SHA-1

            string aString = "Hi this is some sensitive information";

            byte[] bytes = Encoding.UTF8.GetBytes(aString);

            var sha1 = SHA1.Create();

            byte[] hashBytes = sha1.ComputeHash(bytes);

            string hexString = HexStringFromBytes(hashBytes);

            Console.WriteLine(hexString);

        }
        private string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
    }
}
