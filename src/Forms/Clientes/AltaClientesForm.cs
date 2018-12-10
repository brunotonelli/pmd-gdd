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
    public partial class AltaClientesForm : Form
    {
        DataGridView DataGrid;
        private Cliente Nuevo = new Cliente();

        public AltaClientesForm(DataGridView dataGrid) {
            InitializeComponent();
            DataGrid = dataGrid;
            boxTipoDoc.SelectedItem = "DNI";
            AgregarEventosValidacion();
        }

        private void BindearDatos() {
            var piso = boxPiso.Text.Length > 0 ? decimal.Parse(boxPiso.Text) : 0;
            var nroCalle = boxNumero.Text.Length > 0 ? decimal.Parse(boxNumero.Text) : 0;
            var doc = boxNroDoc.Text.Length > 0 ? decimal.Parse(boxNroDoc.Text) : 0;

            Nuevo.Cli_Apellido = boxApellido.Text;
            Nuevo.Cli_Cod_Postal = boxCodigoPostal.Text;
            Nuevo.Cli_CUIL = boxCUIL.Text;
            Nuevo.Cli_Depto = boxDepartamento.Text;
            Nuevo.Cli_Dom_Calle = boxCalle.Text;
            Nuevo.Cli_Fecha_Alta = Configuracion.FechaActual;
            Nuevo.Cli_Fecha_Nac = boxFecha.Value;
            Nuevo.Cli_Habilitado = true;
            Nuevo.Cli_Localidad = boxLocalidad.Text;
            Nuevo.Cli_Mail = boxMail.Text;
            Nuevo.Cli_Nombre = boxNombre.Text;
            Nuevo.Cli_Piso = piso;
            Nuevo.Cli_Nro_Calle = nroCalle;
            Nuevo.Cli_Nro_Doc = doc;
            Nuevo.Cli_Tarjeta_Num = boxNroTarjeta.Text;
            Nuevo.Cli_Tarjeta_Tipo = boxTipoTarjeta.Text;
            Nuevo.Cli_Telefono = boxTelefono.Text;
            Nuevo.Cli_Tipo_Doc = boxTipoDoc.Text;
        }

        private void botonCrear_Click(object sender, EventArgs e) {
            Nuevo.Cli_Tipo_Doc = boxTipoDoc.SelectedItem.ToString();
            decimal doc;
            decimal.TryParse(boxNroDoc.Text, out doc);
            Nuevo.Cli_Nro_Doc = doc;

            bool existeCliente = ValidacionesInput.ExisteCliente(boxTipoDoc.Text, doc, boxCUIL.Text);
            bool cuitValido = ValidacionesInput.CUILValido(boxCUIL.Text) || boxCUIL.Text.Length == 0;
            //le permito no tener cuil, pero si tiene tiene que estar bien

            if (existeCliente)
                MessageBox.Show("Ya existe un cliente con ese tipo de documento / numero de documento / CUIL", "Error de Empresa");
            if (!cuitValido)
                MessageBox.Show("El CUIL ingresado no tiene el formado correcto\nEjemplo: ##-########-#", "Error de CUIL");

            if (!existeCliente && cuitValido)
            {
                BindearDatos();
                using (var context = new GD2C2018Entities())
                {
                    Usuario u = AutogenerarUsuario();
                    context.Entry(u).State = System.Data.Entity.EntityState.Added;
                    context.Entry(Nuevo).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                    DataGrid.DataSource = context.Cliente.ToList();
                }
                this.Close();
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e) {

        }

        private void ValidarRequeridos(object sender, EventArgs e) {
            var nombre = boxNombre.Text;
            var apellido = boxApellido.Text;
            var dni = boxNroDoc.Text;
            var mail = boxMail.Text;
            bool ok = nombre.Length != 0 && apellido.Length != 0 && dni.Length != 0 && mail.Length != 0;
            botonCrear.Enabled = ok;
        }

        private Usuario AutogenerarUsuario() {
            string contraseña = Utilidades.GenerarContraseña(4);
            Usuario usuario = new Usuario
            {
                Usuario_Autogenerado = true,
                Usuario_Habilitado = true,
                Usuario_Inicios = 0,
                Usuario_Intentos_Fallidos = 0,
                Usuario_Username = Utilidades.GenerarUsuario(6),
                Usuario_Password = Utilidades.SHA256Encrypt(contraseña)
            };
            var rolCliente = ConsultasDB.GetRol("CLI");
            usuario.Rol.Add(rolCliente);

            Nuevo.Cli_Usuario = usuario.Usuario_Username;
            MessageBox.Show("Nombre de usuario: " + usuario.Usuario_Username +
                "\nContraseña: " + contraseña +
                "\n\nTome constancia de estos datos e informe al usuario por mail",
                "Usuario autogenerado");
            return usuario;
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
        }

    }
}
