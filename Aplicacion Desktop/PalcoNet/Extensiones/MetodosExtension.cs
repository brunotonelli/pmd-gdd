using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Extensiones
{
    public static class MetodosExtension
    {

        //bindear textboxs y datepickers, por default se bindea a propiedad text (de textbox)
        public static void Bindear(this Control control, object objeto, string columna, string propiedad = "Text", DataSourceUpdateMode modo = DataSourceUpdateMode.OnPropertyChanged) {
            control.DataBindings.Add(propiedad, objeto, columna, true, modo);
        }

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
        
    }
}
