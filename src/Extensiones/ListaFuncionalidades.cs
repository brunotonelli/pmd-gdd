using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Extensiones
{
    public partial class ListaFuncionalidades : UserControl {
        public ListaFuncionalidades() {
            InitializeComponent();
        }

        public List<string> Seleccionadas {
            get { return lista.CheckedItems.Cast<string>().ToList();}
        }
    }
}
