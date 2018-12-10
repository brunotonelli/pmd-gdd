using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Extensiones
{
    public static class MetodosExtension {

        public static Cliente Clonar(this Cliente c) {
            return new Cliente
            {
                Cli_Apellido = c.Cli_Apellido,
                Cli_Cod_Postal = c.Cli_Cod_Postal,
                Cli_CUIL = c.Cli_CUIL,
                Cli_Depto = c.Cli_Depto,
                Cli_Dom_Calle = c.Cli_Dom_Calle,
                Cli_Fecha_Alta = c.Cli_Fecha_Alta,
                Cli_Fecha_Nac = c.Cli_Fecha_Nac,
                Cli_Habilitado = c.Cli_Habilitado,
                Cli_Localidad = c.Cli_Localidad,
                Cli_Mail = c.Cli_Mail,
                Cli_Nombre = c.Cli_Nombre,
                Cli_Nro_Calle = c.Cli_Nro_Calle,
                Cli_Nro_Doc = c.Cli_Nro_Doc,
                Cli_Piso = c.Cli_Piso,
                Cli_Tarjeta_Num = c.Cli_Tarjeta_Num,
                Cli_Tarjeta_Tipo = c.Cli_Tarjeta_Tipo,
                Cli_Telefono = c.Cli_Telefono,
                Cli_Tipo_Doc = c.Cli_Tipo_Doc,
                Cli_Usuario = c.Cli_Usuario
            };
        }

        public static bool Contains(this string source, string toCheck, StringComparison comp) {
            //         return source?.IndexOf(toCheck, comp) >= 0;     

            return source.IndexOf(toCheck, comp) >= 0;
        }

        public static bool Contains(this List<string> source, string toCheck, StringComparison comp) {
            return source.Any(s => s.Contains(toCheck, StringComparison.OrdinalIgnoreCase));
        }

        public static T FirstOr<T>(this IEnumerable<T> source, T alternate) {
            foreach (T t in source)
                return t;
            return alternate;
        }

        public static bool SonIguales(this byte[] a, byte[] b) {
            for (int i = 0; i < a.Length; i++)
                if (a[i] != b[i])
                    return false;
            return true;
        }
    
        public static int Trimestre(this DateTime d) {
            return (int)Math.Floor((d.Month + 2) / 3.0);
        }

        public static Ubicacion ConPublicacion(this Ubicacion u, decimal id_publi) {
            return new Ubicacion
            {
                Ubicacion_Asiento = u.Ubicacion_Asiento,
                Ubicacion_Disponible = true,
                Ubicacion_Fila = u.Ubicacion_Fila,
                Ubicacion_Precio = u.Ubicacion_Precio,
                Ubicacion_Sin_numerar = u.Ubicacion_Sin_numerar,
                Ubicacion_Tipo = u.Ubicacion_Tipo,
                Ubicacion_Publicacion = id_publi
            };
        }

    }
}
