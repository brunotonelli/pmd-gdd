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
    public partial class RegistrarClienteForm : Form
    {
        public RegistrarClienteForm()
        {
            InitializeComponent();
            boxTipoDoc.SelectedIndex = 0;
            AgregarEventosValidacion();
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
            bool existeUsuario = ValidacionesInput.ExisteUsuario(boxUsuario.Text);
            bool existeCliente = ValidacionesInput.ExisteCliente(boxTipoDoc.Text, decimal.Parse(boxNroDoc.Text), boxCUIL.Text);

            if (existeUsuario)
                MessageBox.Show("Ese nombre de usuario ya se encuentra en uso", "Error de Usuario");
            if (existeCliente)
                MessageBox.Show("Ya existe un cliente con ese Tipo y Nro de documento, o bien ese CUIL ya está en uso", "Error de Cliente");

            if (!existeUsuario && !existeCliente)
            {
                var context = new GD2C2018Entities();

                Usuario usuario = new Usuario
                {
                    Usuario_Username = boxUsuario.Text,
                    Usuario_Password = Utilidades.SHA256Encrypt(boxContraseña.Text),
                    Usuario_Intentos_Fallidos = 0,
                    Usuario_Autogenerado = false
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
                    Cli_Fecha_Alta = Configuracion.FechaActual,
                    Cli_Fecha_Nac = boxFecha.Value,
                    Cli_Depto = boxDepartamento.Text,
                    Cli_Localidad = boxLocalidad.Text,
                    Cli_Piso = piso,
                    Cli_Tarjeta_Tipo = boxTipoTarjeta.Text,
                    Cli_Tarjeta_Num = boxNroTarjeta.Text,
                    Cli_Usuario = boxUsuario.Text,
                    Cli_Habilitado = true
                };

                context.Entry(usuario).State = System.Data.Entity.EntityState.Added;
                context.Entry(cliente).State = System.Data.Entity.EntityState.Added;


                var rol = context.Rol.Single(r => r.Rol_ID == "CLI");
                usuario.Rol.Add(rol);               
                context.SaveChanges();

                MessageBox.Show("Usuario creado con éxito!", "Registro de usuario");
                Sesion.LogIn(usuario, rol);
                var menu = MenuForm.ObtenerInstancia(Sesion.Rol);
                this.Close();
                FormsEstaticos.Principal.Hide();
                menu.Show();
            }
        }

        private void AgregarEventosValidacion() {
            var ep = new ValidadorCampos(this);
            ep.AgregarCampo(boxPiso, ValidadorCampos.TipoValidacion.Numerica);
            ep.AgregarCampo(boxNumero, ValidadorCampos.TipoValidacion.Numerica);
            ep.AgregarCampo(boxNroDoc, ValidadorCampos.TipoValidacion.Numerica);
            ep.AgregarCampo(boxNroTarjeta, ValidadorCampos.TipoValidacion.Numerica);
            ep.AgregarCampo(boxCUIL, ValidadorCampos.TipoValidacion.CUIT);
            boxNombre.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxApellido.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxNroDoc.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxUsuario.TextChanged += new EventHandler(ValidarRequeridos);
            boxContraseña.TextChanged += new EventHandler(ValidarRequeridos);
        }
    }
}
