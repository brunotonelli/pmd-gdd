using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Model
{
    public class HistorialModel
    {
        public DateTime Fecha { get; set; }
        public string Espectaculo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public string FormaPago { get; set; }
    }
}
