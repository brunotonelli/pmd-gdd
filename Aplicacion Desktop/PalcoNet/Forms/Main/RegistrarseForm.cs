using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Forms
{
    public partial class RegistrarseForm : Form
    {
        public RegistrarseForm()
        {
            InitializeComponent();
        }

        private void botonEmpresa_Click(object sender, EventArgs e)
        {
            new RegistrarEmpresaForm().Show();
        }

        private void botonCliente_Click(object sender, EventArgs e)
        {
            new RegistrarClienteForm().Show();
        }
    }
}
