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
                               select u).FirstOrDefault();
                
            if (ValidarUsuario(usuario, hash, context)) {
                if (usuario.Usuario_Autogenerado ?? false)
                {
                    if (usuario.Usuario_Inicios > 1)
                    {
                        Inhabilitar(usuario, context);
                        MessageBox.Show("Debía cambiar su contraseña ya que su usuario era autogenerado. Su usuario se encuentra bloqueado.");
                    }
                    else
                    {
                        MessageBox.Show("Su usuario fue autogenerado, debe cambiar la contraseña EN ESTA SESIÓN");
                        new CuentaForm().Show();
                    }
                }
                else
                {
                    var roles = usuario.Rol.ToList();
                    if (roles.Count() == 1)
                    {
                        var rol = roles.First();
                        Sesion.LogIn(usuario, rol);
                        var menu = MenuForm.ObtenerInstancia(rol);
                        this.Close();
                        menu.Show();
                    }
                    else
                    {
                        this.Hide();
                        new SeleccionRolForm(roles, usuario).Show(this);                        
                    }
                }
            }
        }

        private bool ValidarUsuario(Usuario usuario, byte[] hash, GD2C2018Entities context) {
            if (usuario == null)
                MessageBox.Show("Usuario inexistente", "Error de inicio de sesión");
            else if (!(usuario.Usuario_Habilitado ?? true))
                MessageBox.Show("Su usuario se encuentra bloqueado. Contacte a un administrador", "Error de inicio de sesión");
            else if (usuario.Usuario_Intentos_Fallidos >= 3)
                MessageBox.Show("Usuario bloqueado por tener más de 3 inicios de sesión incorrectos", "Error de inicio de sesión");
            else if (!hash.SonIguales(usuario.Usuario_Password))
            {
                MessageBox.Show("Contraseña incorrecta, se suma 1 intento fallido", "Error de inicio de sesión");
                usuario.Usuario_Intentos_Fallidos++;
                if (usuario.Usuario_Intentos_Fallidos >= 3)
                {
                    MessageBox.Show("Usuario bloqueado por tener más de 3 inicios de sesión incorrectos", "Error de inicio de sesión");
                    usuario.Usuario_Habilitado = false;
                }
                context.SaveChanges();
            }
            else return true;
            return false;
        }

        private void Inhabilitar(Usuario usuario, GD2C2018Entities context) {
            usuario.Usuario_Habilitado = false;
            context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

    }
}
