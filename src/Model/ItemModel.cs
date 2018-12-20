using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Model
{
    public class ItemModel
    {
        public string Concepto { get { return Descripcion + " de $" + MontoCompra; } }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal MontoCompra { get; set; }
        public string PrecioString { get; set; }
    }
}
