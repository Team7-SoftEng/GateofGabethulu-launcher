using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LauncherPrototype
{
    class Crypto
    {

        private UTF8Encoding ue;
        private SHA512Managed sha;
        private StringBuilder strBuild;

        public String generateSHA512PasswordHash(String plaintext)
        {

            ue = new UTF8Encoding();
            sha = new SHA512Managed();
            strBuild = new StringBuilder();
            byte[] hashBytes = sha.ComputeHash(ue.GetBytes(plaintext));

            for (int i = 0; i < hashBytes.Length; i++)
            {

                strBuild.Append(hashBytes[i].ToString("x2").ToLower());

            }

            return strBuild.ToString();

        }

    }
}
