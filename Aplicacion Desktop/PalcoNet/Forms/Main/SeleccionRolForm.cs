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
    public partial class SeleccionRolForm : Form
    {
        List<Rol> Roles;
        Usuario Usuario;

        public SeleccionRolForm(List<Rol> roles, Usuario usuario) {
            InitializeComponent();
            Roles = roles;
            Usuario = usuario;
            CargarRoles();
        }

        private void CargarRoles() {
            Roles.ForEach(r => boxRol.Items.Add(r.Rol_Nombre));
            boxRol.SelectedIndex = 0;
        }

        private void botonContinuar_Click(object sender, EventArgs e) {
            var rol = Roles.Single(r => r.Rol_Nombre == boxRol.Text);
            Sesion.LogIn(Usuario, rol);
            var menu = MenuForm.ObtenerInstancia(rol);
            Owner.Close();
            this.Close();
            menu.Show();
        }

        private void SeleccionRolForm_FormClosed(object sender, FormClosedEventArgs e) {
            Owner.Show();
        }
    }
}
