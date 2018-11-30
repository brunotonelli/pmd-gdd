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
        public string Empresa { get; set; }
        public decimal Publicacion_ID { get; set; }
        public string Compra_Tipo_Doc_Cliente { get; set; }
        public decimal Compra_Num_Doc_Cliente { get; set; }
        public decimal Cantidad { get; set; }
    }
}
