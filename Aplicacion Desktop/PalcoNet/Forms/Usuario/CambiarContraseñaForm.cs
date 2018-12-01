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
    public partial class CambiarContraseñaForm : Form
    {
        public CambiarContraseñaForm() {
            InitializeComponent();
            this.AcceptButton = this.botonConfirmar;
        }

        private void botonConfirmar_Click(object sender, EventArgs e) {
            byte[] realBytes = Sesion.Usuario.Usuario_Password;
            string actual = boxActual.Text, nueva = boxNueva.Text, confirmar = boxConfirmar.Text;
            byte[] actualBytes = Utilidades.SHA256Encrypt(actual);
            string mensaje;
            if (!actualBytes.SonIguales(realBytes))
                mensaje = "No coincide la contraseña actual con la ingresada";
            else if (nueva != confirmar)
                mensaje = "No coincide la contraseña nueva con el campo de confirmación";
            else
            {
                using (var context = new GD2C2018Entities())
                {
                    var query = from u in context.Usuario
                                where u.Usuario_Username == Sesion.Usuario.Usuario_Username
                                select u;
                    Usuario usuario = query.Single();
                    usuario.Usuario_Password = Utilidades.SHA256Encrypt(nueva);
                    usuario.Usuario_Autogenerado = false;
                    context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    mensaje = "Contraseña cambiada con éxito";
                    Sesion.Usuario = usuario;
                    this.Close();
                }
            }
            MessageBox.Show(mensaje, string.Empty, MessageBoxButtons.OK);
        }

        private void CambiarContraseñaForm_Load(object sender, EventArgs e) {

        }
    }
}
