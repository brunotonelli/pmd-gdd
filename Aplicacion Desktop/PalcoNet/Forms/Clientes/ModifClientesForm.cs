using PalcoNet.Extensiones;
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
        private Cliente Seleccionado;

        public ModifClientesForm(Cliente cliente) {
            InitializeComponent();
            Documento = cliente.Cli_Nro_Doc;
            Seleccionado = cliente;
            BindearCampos();
            boxNombre.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxApellido.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxNroDoc.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
        }

        private void BindearCampos() {
            boxNombre.Bindear(Seleccionado, "Cli_Nombre");
            boxApellido.Bindear(Seleccionado, "Cli_Apellido");
            boxNroDoc.Bindear(Seleccionado, "Cli_Nro_Doc");
            boxTipoDoc.Bindear(Seleccionado, "Cli_Tipo_Doc");
            boxMail.Bindear(Seleccionado, "Cli_Mail");
            boxCUIL.Bindear(Seleccionado, "Cli_CUIL");
            boxFecha.Bindear(Seleccionado, "Cli_Fecha_Nac", "Value");
            boxTelefono.Bindear(Seleccionado, "Cli_Telefono");
            boxCalle.Bindear(Seleccionado, "Cli_Dom_Calle");
            boxNumero.Bindear(Seleccionado, "Cli_Nro_Calle");
            boxPiso.Bindear(Seleccionado, "Cli_Piso");
            boxDepartamento.Bindear(Seleccionado, "Cli_Depto");
            boxCodigoPostal.Bindear(Seleccionado, "Cli_Cod_Postal");
            boxLocalidad.Bindear(Seleccionado, "Cli_Localidad");
            boxTipoTarjeta.Bindear(Seleccionado, "Cli_Tarjeta_Tipo");
            boxNroTarjeta.Bindear(Seleccionado, "Cli_Tarjeta_Num");
        }

        private void botonGuardar_Click(object sender, EventArgs e) {
            using (var context = new GD2C2018Entities())
            {
                var cliente = context.Cliente.Single(c => c.Cli_Nro_Doc == Documento);
                context.Entry(cliente).CurrentValues.SetValues(Seleccionado);
                context.SaveChanges();
            }
            this.Close();
        }

        private void ValidarRequeridos(object sender, EventArgs e) {
            var nombre = boxNombre.Text;
            var apellido = boxApellido.Text;
            var dni = boxNroDoc.Text;
            var mail = boxMail.Text;
            bool ok = nombre.Length != 0 && apellido.Length != 0 && dni.Length != 0 && mail.Length != 0;
            botonGuardar.Enabled = ok;
        }

        private void ModifClientesForm_Load(object sender, EventArgs e) {

        }
    }
}
