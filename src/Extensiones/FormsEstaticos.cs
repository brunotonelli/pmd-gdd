using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Extensiones
{
    //cuando se inicia la aplicacion, asi tengo una referencia al origen de los forms y puedo volver
    public static class FormsEstaticos
    {
        public static Form Principal { get; set; }
    }
}
