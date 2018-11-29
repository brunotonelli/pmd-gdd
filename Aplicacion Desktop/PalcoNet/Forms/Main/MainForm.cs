using PalcoNet.Extensiones;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormsEstaticos.Principal = this;
        }
               
        private void botonLogin_Click(object sender, EventArgs e) {
            new LoginForm().Show();
            this.Hide();
        }

        private void botonRegistrarse_Click(object sender, EventArgs e) {
            new RegistrarseForm().Show();
            this.Hide();
        }
    }
}
