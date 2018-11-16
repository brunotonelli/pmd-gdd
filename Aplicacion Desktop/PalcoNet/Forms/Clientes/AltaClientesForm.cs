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

namespace PalcoNet.Forms.Clientes
{
    public partial class AltaClientesForm : Form
    {
        public AltaClientesForm() {
            InitializeComponent();
            boxNombre.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxApellido.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxDNI.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
        }

        private void botonCrear_Click(object sender, EventArgs e) {

        }

        private void botonCancelar_Click(object sender, EventArgs e) {

        }

        private void ValidarRequeridos(object sender, EventArgs e) {
            var nombre = boxNombre.Text;
            var apellido = boxApellido.Text;
            var dni = boxDNI.Text;
            var mail = boxMail.Text;
            bool ok = nombre.Length != 0 && apellido.Length != 0 && dni.Length != 0 && mail.Length != 0;
            botonCrear.Enabled = ok;
        }
        
    }
}
