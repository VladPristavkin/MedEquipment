using System.Security.Cryptography;
using System.Text;

namespace MedEquipment.Utils
{
    public static class HashHelper
    {
        public static string HashString(string str)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(str);

                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2")); 
                }

                return builder.ToString();
            }
        }
    }
}
