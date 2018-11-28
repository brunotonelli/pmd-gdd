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
    public partial class LoginForm : Form
    {
        public LoginForm() {
            InitializeComponent();
            this.AcceptButton = this.botonIniciar;
        }

        private void checkMostrar_CheckedChanged(object sender, EventArgs e) {
            boxContraseña.UseSystemPasswordChar = !checkMostrar.Checked;
        }

        private void botonIniciar_Click(object sender, EventArgs e) {
            byte[] hash = Utilidades.SHA256Encrypt(boxContraseña.Text);

            var context = new GD2C2018Entities();
            Usuario usuario = (from u in context.Usuario
                               where u.Usuario_Username == boxUsuario.Text
                                     && u.Usuario_Password == hash
                               select u).FirstOrDefault();

            if (usuario == null)
                MessageBox.Show("Datos de inicio de sesión incorrectos", "Error de inicio de sesión");
            else
            {
                var menu = new MenuForm(usuario);
                this.Close();
                InfoSesion.Usuario = usuario;

                InfoSesion.NroDocumento = (from c in context.Cliente
                                           where c.Cli_Usuario == boxUsuario.Text
                                           select c.Cli_Nro_Doc).FirstOrDefault();

                InfoSesion.TipoDocumento = (from c in context.Cliente
                                           where c.Cli_Usuario == boxUsuario.Text
                                           select c.Cli_Tipo_Doc).FirstOrDefault();

                menu.Show();
            }
        }
    }
}
