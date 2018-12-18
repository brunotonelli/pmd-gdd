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
    //se pensó para reutilizarlo en forms que requieran listar las funcionalidades, al final quedó
    //se usa solo en la creacion/modif de roles
    public partial class ListaFuncionalidades : UserControl {
        public ListaFuncionalidades() {
            InitializeComponent();
        }

        public List<string> Seleccionadas {
            get { return lista.CheckedItems.Cast<string>().ToList();}
        }

        public void Seleccionar(string item)
        {
            var items = lista.Items.Cast<string>().ToList();
            int indice = items.IndexOf(item);
            lista.SetItemChecked(indice, true);
        }
    }
}
