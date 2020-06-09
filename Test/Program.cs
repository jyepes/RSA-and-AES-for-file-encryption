using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encryptor;
using FileEncryptor;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            GenerateRSAKeyPair();

        }

        private static void GenerateRSAKeyPair()
        {
            string publicKey = string.Empty;
            string privateKey = string.Empty;
            Encipher.GenerateRSAKeyPair(out publicKey, out privateKey);
        }
    }
}
