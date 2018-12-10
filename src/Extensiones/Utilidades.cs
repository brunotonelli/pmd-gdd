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

        public static string GenerarContraseña(int length) {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
                stringChars[i] = chars[random.Next(chars.Length)];
            return new string(stringChars);
        }

        public static string GenerarUsuario(int length) {
            return Guid.NewGuid().ToString("n").Substring(0, length);
        }
    }
}
