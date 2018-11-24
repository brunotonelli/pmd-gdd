using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Extensiones
{
    public class Utilidades
    {
        public static byte[] SHA256Encrypt(string input) {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            return provider.ComputeHash(inputBytes);
        }
    }
}
