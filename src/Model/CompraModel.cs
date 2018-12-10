using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Model
{
    public class CompraModel
    {
        public decimal ID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Empresa { get; set; }
        public string Espectaculo { get; set; }
        public decimal PublicacionID { get; set; }
        public decimal Cantidad { get; set; }
    }
}
