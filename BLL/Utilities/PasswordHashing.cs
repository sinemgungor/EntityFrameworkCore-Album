using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Utilities
{
    public class Class1
    {
        public string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        public static bool IsPasswordValid(string password)
        {
            // Şifre kriterlerini kontrol et
            return password.Length >= 8 &&
                   password.Count(char.IsUpper) >= 2 &&
                   password.Count(char.IsLower) >= 3 &&
                   password.Count(c => "!:+*".Contains(c)) >= 2;
        }
    }
}
