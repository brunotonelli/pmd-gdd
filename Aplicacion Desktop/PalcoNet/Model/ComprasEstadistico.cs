using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Model
{
    public class ComprasEstadistico
    {
        /*public ComprasEstadistico() { }
        public ComprasEstadistico(string tipoDoc,int nroDoc,string nombre,string apellido,int cantCompras) {
            this.tipoDoc = tipoDoc;
            this.nroDoc = nroDoc;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cantCompras = cantCompras;
        }*/
        public int Cli_Nro_Doc { get; set; }
        public string Cli_Tipo_Doc { get; set; }
        public string Cli_Nombre { get; set; }
        public string Cli_Apellido { get; set; }
        public int Entradas_Compradas { get; set; }
    }
}
