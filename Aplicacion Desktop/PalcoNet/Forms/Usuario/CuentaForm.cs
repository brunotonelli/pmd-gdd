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
    public partial class CuentaForm : Form
    {
        public CuentaForm() {
            InitializeComponent();
            var rol = InfoSesion.Usuario.Usuario_Rol;
            labelRol.Text = InfoSesion.Usuario.Usuario_Rol;
            labelIntentos.Text = InfoSesion.Usuario.Usuario_Intentos_Fallidos.ToString();
            labelUsuario.Text = InfoSesion.Usuario.Usuario_Username;
            botonCambiarDatos.Enabled = rol == "EMP" || rol == "CLI";
            botonCambiarDatos.Text = "Cambiar datos de " + rol;
        }

        private void botonVolver_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void botonCambiar_Click(object sender, EventArgs e) {
            new CambiarContraseñaForm().Show();
        }

        private void botonCambiarDatos_Click(object sender, EventArgs e) {
            if (InfoSesion.Usuario.Usuario_Rol == "CLI")
                new ModifClientesForm(InfoSesion.GetCliente()).Show();
            else
                new ModifEmpresasForm(InfoSesion.GetEmpresa()).Show();
        }
    }
}
