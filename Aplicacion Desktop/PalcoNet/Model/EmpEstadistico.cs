using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Model
{
    public class EmpEstadistico
    {
        public string Espec_Empresa_Cuit { get; set; }
        public string Espec_Empresa_Razon_Social { get; set; }
        public decimal Publicacion_ID { get; set; }
        public decimal Cantidad { get; set; }
    }
}
