using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WPF_client
{
    static class Encryption
    {
        static public string StringToMD5(string s)
        {
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();
            UTF8Encoding e = new UTF8Encoding();
            byte[] b = csp.ComputeHash(e.GetBytes(s));
            string password = "";
            for (int i = 0; i < b.Length; i++)
            {
                password += b[i];
            }

            return password;
        }
    }
}
