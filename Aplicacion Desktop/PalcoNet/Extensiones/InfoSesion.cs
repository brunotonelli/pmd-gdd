using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Extensiones
{
    public static class InfoSesion
    {
        public static Usuario Usuario { get; set; }
        public static string TipoDocumento { get; set; }
        public static decimal NroDocumento { get; set; }
        public static string CUITEmpresa { get; set; }

        public static void LogIn(Usuario usuario) {
            LogIn(usuario, new GD2C2018Entities());
        }

        public static void LogIn(Usuario usuario, GD2C2018Entities context) {
            Usuario = usuario;
            usuario.Usuario_Inicios++;
            context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            var queryCli = from c in context.Cliente
                        where c.Cli_Usuario == usuario.Usuario_Username
                        select new { c.Cli_Tipo_Doc, c.Cli_Nro_Doc };
            var cliente = queryCli.FirstOrDefault();
            NroDocumento = cliente != null ? cliente.Cli_Nro_Doc : 0;
            TipoDocumento = cliente != null ? cliente.Cli_Tipo_Doc : "DNI";
            var queryEmp = from e in context.Espec_Empresa
                           where e.Espec_Empresa_Usuario == usuario.Usuario_Username
                           select new { e.Espec_Empresa_Cuit };
            var empresa = queryEmp.FirstOrDefault();
            CUITEmpresa = empresa != null ? empresa.Espec_Empresa_Cuit : "0";
        }

        public static void LogOut() {
            Usuario = null;
            NroDocumento = decimal.Zero;
            TipoDocumento = null;
            CUITEmpresa = null;
        }

        public static Espec_Empresa GetEmpresa() {
            var context = new GD2C2018Entities();
            return (from e in context.Espec_Empresa
                    where e.Espec_Empresa_Usuario == Usuario.Usuario_Username
                    select e).Single();
        }

        public static Cliente GetCliente() {
            var context = new GD2C2018Entities();
            return (from c in context.Cliente
                    where c.Cli_Usuario == Usuario.Usuario_Username
                    select c).Single();
        }
    }
}
