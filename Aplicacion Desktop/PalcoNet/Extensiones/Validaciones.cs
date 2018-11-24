﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalcoNet.Extensiones
{
    public class Validaciones
    {

        public static bool ExisteUsuario(string usuario) {
            using (var context = new GD2C2018Entities())
            {
                var usuarios = from u in context.Usuario
                               select u.Usuario_Username;
                return usuarios.Any(u => u.Equals(usuario, StringComparison.OrdinalIgnoreCase));
            }
        }

        public static bool ExisteEmpresa(string razon, string cuit) {
            using (var context = new GD2C2018Entities())
            {
                var empresas = from e in context.Espec_Empresa
                               select new
                               {
                                   razon = e.Espec_Empresa_Razon_Social,
                                   cuit = e.Espec_Empresa_Cuit
                               };
                return empresas.Any
                    (e => e.razon.Equals(razon, StringComparison.OrdinalIgnoreCase) ||
                    e.cuit.Equals(cuit, StringComparison.OrdinalIgnoreCase));
            }
        }

        public static bool ExisteCliente(string tipo, string numero, string cuil) {
            var dni = decimal.Parse(numero);
            using (var context = new GD2C2018Entities())
            {
                var clientes = from c in context.Cliente
                               select new
                               {
                                   tipo = c.Cli_Tipo_Doc,
                                   numero = c.Cli_Nro_Doc,
                                   cuil = c.Cli_CUIL
                               };
                return clientes.Any
                    (c => (c.tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)
                    && c.numero == dni)
                    || c.cuil.Equals(cuil, StringComparison.OrdinalIgnoreCase));
            }
        }

        public static bool CUILValido(string cuil) {
            var expresion = new Regex("\\d\\d-\\d\\d\\d\\d\\d\\d\\d\\d-\\d");
            return expresion.IsMatch(cuil);
        }
    }
}