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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ClientesForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RolesForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new RegistrarseForm().Show();
        }

        private void botonLogin_Click(object sender, EventArgs e) {
            new LoginForm().Show();
        }
    }
}
