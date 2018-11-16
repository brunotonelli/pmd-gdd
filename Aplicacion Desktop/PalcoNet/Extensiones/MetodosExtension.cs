using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Extensiones
{
    public static class MetodosExtension
    {

        //bindear textboxs y datepickers, por default se bindea a propiedad text (de textbox)
        public static void Bindear(this Control control, object objeto, string columna, string propiedad = "Text") {
            control.DataBindings.Add(propiedad, objeto, columna, true, DataSourceUpdateMode.OnPropertyChanged);
        }
        
    }
}
