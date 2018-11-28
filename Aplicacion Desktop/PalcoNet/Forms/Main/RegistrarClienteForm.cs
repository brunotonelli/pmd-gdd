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
    public partial class RegistrarClienteForm : Form
    {
        public RegistrarClienteForm()
        {
            InitializeComponent();
            boxTipoDoc.SelectedIndex = 0;
            boxNombre.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxApellido.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxNroDoc.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxUsuario.TextChanged += new EventHandler(ValidarRequeridos);
            boxContraseña.TextChanged += new EventHandler(ValidarRequeridos);
        }

        private void ValidarRequeridos(object sender, EventArgs e) {
            var nombre = boxNombre.Text;
            var apellido = boxApellido.Text;
            var dni = boxNroDoc.Text;
            var mail = boxMail.Text;
            var usuario = boxUsuario.Text;
            var contraseña = boxContraseña.Text;
            bool ok = nombre.Length != 0 && apellido.Length != 0 && mail.Length != 0 &&
                usuario.Length != 0 && contraseña.Length != 0 && dni.Length != 0;
            botonRegistrarse.Enabled = ok;
        }

        private void botonRegistrarse_Click(object sender, EventArgs e) {
            bool existeUsuario = Validaciones.ExisteUsuario(boxUsuario.Text);
            bool existeCliente = Validaciones.ExisteCliente(boxTipoDoc.Text, boxNroDoc.Text, boxCUIL.Text);
            bool cuilValido = Validaciones.CUILValido(boxCUIL.Text);

            if (existeUsuario)
                MessageBox.Show("Ese nombre de usuario ya se encuentra en uso", "Error de Usuario");
            if (existeCliente)
                MessageBox.Show("Ya existe un cliente con ese Tipo y Nro de documento, o bien ese CUIL ya está en uso", "Error de Cliente");
            if (!cuilValido)
                MessageBox.Show("El CUIL ingresado no tiene el formado correcto\nEjemplo: ##-########-#", "Error de CUIL");

            if (!existeUsuario && !existeCliente && cuilValido)
            {
                Usuario usuario = new Usuario
                {
                    Usuario_Username = boxUsuario.Text,
                    Usuario_Password = Utilidades.SHA256Encrypt(boxContraseña.Text),
                    Usuario_Intentos_Fallidos = 0,
                    Usuario_Rol = "CLI"
                };

                var piso = boxPiso.Text.Length > 0 ? decimal.Parse(boxPiso.Text) : 0;
                var nroCalle = boxNumero.Text.Length > 0 ? decimal.Parse(boxNumero.Text) : 0;
                var doc = boxNroDoc.Text.Length > 0 ? decimal.Parse(boxNroDoc.Text) : 0;

                Cliente cliente = new Cliente
                {
                    Cli_Tipo_Doc = boxTipoDoc.Text,
                    Cli_Nro_Doc = doc,
                    Cli_CUIL = boxCUIL.Text,
                    Cli_Nombre = boxNombre.Text,
                    Cli_Apellido = boxApellido.Text,
                    Cli_Mail = boxMail.Text,
                    Cli_Telefono = boxTelefono.Text,
                    Cli_Dom_Calle = boxCalle.Text,
                    Cli_Nro_Calle = nroCalle,
                    Cli_Cod_Postal = boxCodigoPostal.Text,
                    Cli_Fecha_Alta = DateTime.Now,
                    Cli_Fecha_Nac = boxFecha.Value,
                    Cli_Depto = boxDepartamento.Text,
                    Cli_Localidad = boxLocalidad.Text,
                    Cli_Piso = piso,
                    Cli_Tarjeta_Tipo = boxTipoTarjeta.Text,
                    Cli_Tarjeta_Num = boxNroTarjeta.Text,
                    Cli_Usuario = boxUsuario.Text
                };

                using (var context = new GD2C2018Entities())
                {
                    context.Entry(usuario).State = System.Data.Entity.EntityState.Added;
                    context.Entry(cliente).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();

                    InfoSesion.NroDocumento = (from c in context.Cliente
                                               where c.Cli_Usuario == boxUsuario.Text
                                               select c.Cli_Nro_Doc).FirstOrDefault();

                    InfoSesion.TipoDocumento = (from c in context.Cliente
                                                where c.Cli_Usuario == boxUsuario.Text
                                                select c.Cli_Tipo_Doc).FirstOrDefault();
                }
                InfoSesion.Usuario = usuario;
                MessageBox.Show("Usuario creado con éxito!", "Registro de usuario");
                var menu = new MenuForm(usuario);
                this.Close();



                menu.Show();
            }
        }
    }
}
