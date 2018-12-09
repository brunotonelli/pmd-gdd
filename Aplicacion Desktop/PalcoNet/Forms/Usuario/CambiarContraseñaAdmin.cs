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
    public partial class CambiarContraseñaAdmin : Form
    {
        public Usuario User;
        public CambiarContraseñaAdmin(Usuario usuario) {
            InitializeComponent();
            this.AcceptButton = this.botonConfirmar;
            User = usuario;
        }

        private void botonConfirmar_Click(object sender, EventArgs e) {
            string nueva = boxNueva.Text, confirmar = boxConfirmar.Text;
            string mensaje;
            if (nueva != confirmar)
                mensaje = "No coincide la contraseña nueva con el campo de confirmación";
            else
            {
                using (var context = new GD2C2018Entities())
                {
                    var query = from u in context.Usuario
                                where u.Usuario_Username == User.Usuario_Username
                                select u;
                    Usuario usuario = query.Single();
                    usuario.Usuario_Password = Utilidades.SHA256Encrypt(nueva);
                    context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    mensaje = "Contraseña cambiada con éxito";
                    this.Close();
                }
            }
            MessageBox.Show(mensaje, string.Empty, MessageBoxButtons.OK);
        }
    }
}
