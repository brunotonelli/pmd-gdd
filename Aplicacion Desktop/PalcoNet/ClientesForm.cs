using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    public partial class ClientesForm : Form
    {
        public ClientesForm() {
            InitializeComponent();
            using (var context = new GD2C2018Entities())
            {
                var query = from cliente in context.Cliente
                               select cliente;
                clienteBindingSource.DataSource = query.ToList();
            }
        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e) {

        }
    }
}
