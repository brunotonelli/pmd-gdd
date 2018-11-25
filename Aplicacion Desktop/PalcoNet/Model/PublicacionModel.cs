using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Model
{
    public class PublicacionModel
    {
        public decimal ID { get; set; }
        public string Nombre { get; set; }
        public string Rubro { get; set; }
        public string RangoFecha {
            get {
                return FechaInicial.ToShortDateString() + " - " + FechaFinal.ToShortDateString();
            }
        }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Empresa { get; set; }
        public int Localidades { get; set; }
    }
}
