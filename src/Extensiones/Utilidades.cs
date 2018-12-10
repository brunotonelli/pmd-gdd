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
        //encriptar en SHA256 la pw
        public static byte[] SHA256Encrypt(string input) {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            return provider.ComputeHash(inputBytes);
        }

        //se usa cuando el admin crea un nuevo cli/emp. se les autogenera un usuario/pw con lo
        //que pide el enunciado
        public static string GenerarContraseña(int length) {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
                stringChars[i] = chars[random.Next(chars.Length)];
            return new string(stringChars);
        }

        //idem
        public static string GenerarUsuario(int length) {
            return Guid.NewGuid().ToString("n").Substring(0, length);
        }
    }
}
