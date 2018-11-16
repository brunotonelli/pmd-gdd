using PalcoNet.Forms.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Extensiones;

namespace PalcoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e) {
            new ClientesForm().Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            new AltaClientesForm().Show();
        }
    }
}
