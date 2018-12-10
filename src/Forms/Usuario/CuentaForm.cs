using PalcoNet.Extensiones;
using PalcoNet.Validaciones;
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
            var rol = Sesion.Rol.Rol_ID;
            labelRol.Text = rol;
            labelIntentos.Text = Sesion.Usuario.Usuario_Intentos_Fallidos.ToString();
            labelUsuario.Text = Sesion.Usuario.Usuario_Username;
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
            if (Sesion.Rol.Rol_ID == "CLI")
                new ModifClientesForm(Sesion.Cliente).Show();
            else
                new ModifEmpresasForm(Sesion.Empresa).Show();
        }

        private void CuentaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }
    }
}
