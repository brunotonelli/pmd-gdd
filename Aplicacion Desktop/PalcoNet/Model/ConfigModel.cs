using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet
{
    public class ConfigModel
    {
        public string Servidor { get; set; }
        public string BaseDeDatos { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaActual { get; set; }
    }
}
