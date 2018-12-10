using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Validaciones
{
    public static class Sesion
    {
        public static Usuario Usuario { get; set; }

        public static Rol Rol { get; set; }

        public static Cliente Cliente {
            get {
                return new GD2C2018Entities().Cliente.Single(c => c.Cli_Usuario == Usuario.Usuario_Username);
            }
        }

        public static Espec_Empresa Empresa {
            get {
                return new GD2C2018Entities().Espec_Empresa.Single(e => e.Espec_Empresa_Usuario == Usuario.Usuario_Username);
            }
        }

        public static void LogIn(Usuario usuario, Rol rol) {
            Usuario = usuario;
            Rol = rol;
        }

        public static void LogOut() {
            Usuario = null;
            Rol = null;
        }
    }
}
