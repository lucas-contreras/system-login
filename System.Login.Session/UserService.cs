using System.Security.Cryptography;
using System.Text;

namespace System.Login.Session
{
    public class UserService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string ComposeSHA256(string value)
        {
            if (String.Empty == value)
            {
                throw new Exception("Value should not be empty string");
            }

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(value));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }

        }
    }
}
