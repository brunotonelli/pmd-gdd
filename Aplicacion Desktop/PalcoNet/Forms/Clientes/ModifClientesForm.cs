using PalcoNet.Extensiones;
using PalcoNet.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Forms
{
    [System.ComponentModel.DefaultBindingProperty("Text")]
    public partial class ModifClientesForm : Form
    {
        private decimal Documento;
        private string TipoDocumento;
        private Cliente Seleccionado;

        public ModifClientesForm(Cliente cliente) {
            InitializeComponent();
            Documento = cliente.Cli_Nro_Doc;
            TipoDocumento = cliente.Cli_Tipo_Doc;
            Seleccionado = cliente;
            BindearCampos(Seleccionado);
            AgregarEventosValidacion();
        }

        private void BindearCampos(Cliente c) {
            boxApellido.Text = c.Cli_Apellido;
            boxCodigoPostal.Text = c.Cli_Cod_Postal;
            boxCUIL.Text = c.Cli_CUIL;
            boxDepartamento.Text = c.Cli_Depto;
            boxCalle.Text = c.Cli_Dom_Calle;
            boxFecha.Value = c.Cli_Fecha_Nac.Value;
            checkHabilitado.Checked = c.Cli_Habilitado;
            boxLocalidad.Text = c.Cli_Localidad;
            boxMail.Text = c.Cli_Mail;
            boxNombre.Text = c.Cli_Nombre;
            boxNumero.Text = c.Cli_Nro_Calle.ToString();
            boxNroDoc.Text = c.Cli_Nro_Doc.ToString();
            boxPiso.Text = c.Cli_Piso.ToString();
            boxNroTarjeta.Text = c.Cli_Tarjeta_Num;
            boxTipoTarjeta.Text = c.Cli_Tarjeta_Tipo;
            boxTelefono.Text = c.Cli_Telefono;
            boxTipoDoc.Text = c.Cli_Tipo_Doc;
        }

        private void BindearDatos() {
            var piso = boxPiso.Text.Length > 0 ? decimal.Parse(boxPiso.Text) : 0;
            var nroCalle = boxNumero.Text.Length > 0 ? decimal.Parse(boxNumero.Text) : 0;
            var doc = boxNroDoc.Text.Length > 0 ? decimal.Parse(boxNroDoc.Text) : 0;

            Seleccionado.Cli_Apellido = boxApellido.Text;
            Seleccionado.Cli_Cod_Postal = boxCodigoPostal.Text;
            Seleccionado.Cli_CUIL = boxCUIL.Text;
            Seleccionado.Cli_Depto = boxDepartamento.Text;
            Seleccionado.Cli_Dom_Calle = boxCalle.Text;
            Seleccionado.Cli_Fecha_Nac = boxFecha.Value;
            Seleccionado.Cli_Habilitado = checkHabilitado.Checked;
            Seleccionado.Cli_Localidad = boxLocalidad.Text;
            Seleccionado.Cli_Mail = boxMail.Text;
            Seleccionado.Cli_Nombre = boxNombre.Text;
            Seleccionado.Cli_Nro_Calle = nroCalle;
            Seleccionado.Cli_Nro_Doc = doc;
            Seleccionado.Cli_Piso = piso;
            Seleccionado.Cli_Tarjeta_Num = boxNroTarjeta.Text;
            Seleccionado.Cli_Tarjeta_Tipo = boxTipoTarjeta.Text;
            Seleccionado.Cli_Telefono = boxTelefono.Text;
            Seleccionado.Cli_Tipo_Doc = boxTipoDoc.Text;
        }

        private void botonGuardar_Click(object sender, EventArgs e) {

            bool existeCUIL = ValidacionesInput.ExisteCUIL(boxTipoDoc.Text, decimal.Parse(boxNroDoc.Text), boxCUIL.Text) 
                && boxCUIL.Text.Length != 0;

            bool cuitValido = ValidacionesInput.CUILValido(boxCUIL.Text) || boxCUIL.Text.Length == 0;
            //le permito no tener cuil, pero si tiene tiene que estar bien

            if (existeCUIL)
                MessageBox.Show("Ya existe un cliente con ese CUIL", "Error de Cliente");
            if (!cuitValido)
                MessageBox.Show("El CUIL ingresado no tiene el formado correcto\nEjemplo: ##-########-#", "Error de CUIL");

            if (!existeCUIL && cuitValido)
            {
                BindearDatos();
                using (var context = new GD2C2018Entities())
                {
                    var cliente = context.Cliente.Single(c => c.Cli_Nro_Doc == Documento && c.Cli_Tipo_Doc == TipoDocumento);
                    context.Entry(cliente).CurrentValues.SetValues(Seleccionado);
                    context.SaveChanges();
                    ((ClientesForm)Owner).ActualizarColor(Seleccionado);
                }
                this.Close();
            }
        }

        private void ValidarRequeridos(object sender, EventArgs e) {
            var nombre = boxNombre.Text;
            var apellido = boxApellido.Text;
            var dni = boxNroDoc.Text;
            var mail = boxMail.Text;
            bool ok = nombre.Length != 0 && apellido.Length != 0 && dni.Length != 0 && mail.Length != 0;
            botonGuardar.Enabled = ok;
        }

        private void botonCancelar_Click(object sender, EventArgs e) {
            this.Close();
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
