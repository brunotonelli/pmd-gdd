using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Model
{
    public class UbicacionModel
    {
        public decimal Publicacion { get; set; }
        public string Fila { get; set; }
        public decimal Asiento { get; set; }
        public string Enumerado { get; set; }
        public decimal Precio { get; set; }
        public string Tipo { get; set; }
        public bool Disponible { get; set; }
    }
}
