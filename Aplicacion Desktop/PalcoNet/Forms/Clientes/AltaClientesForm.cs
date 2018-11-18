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

namespace PalcoNet.Forms.Clientes
{
    public partial class AltaClientesForm : Form
    {
        DataGridView DataGrid;
        private Cliente Nuevo = new Cliente();

        public AltaClientesForm(DataGridView dataGrid) {
            InitializeComponent();
            DataGrid = dataGrid;
            BindearCampos();
            boxNombre.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxApellido.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxDNI.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
        }

        private void botonCrear_Click(object sender, EventArgs e) {
            using (var context = new GD2C2018Entities())
            {
                context.Entry(Nuevo).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                DataGrid.DataSource = context.Cliente.ToList();
            }
            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e) {

        }

        private void ValidarRequeridos(object sender, EventArgs e) {
            var nombre = boxNombre.Text;
            var apellido = boxApellido.Text;
            var dni = boxDNI.Text;
            var mail = boxMail.Text;
            bool ok = nombre.Length != 0 && apellido.Length != 0 && dni.Length != 0 && mail.Length != 0;
            botonCrear.Enabled = ok;
        }

        private void BindearCampos() {
            boxNombre.Bindear(Nuevo, "Cli_Nombre");
            boxApellido.Bindear(Nuevo, "Cli_Apellido");
            boxDNI.Bindear(Nuevo, "Cli_Dni");
            boxMail.Bindear(Nuevo, "Cli_Mail");
            boxCUIL.Bindear(Nuevo, "Cli_CUIL");
            boxFecha.Bindear(Nuevo, "Cli_Fecha_Nac", "Value");
            boxTelefono.Bindear(Nuevo, "Cli_Telefono");
            boxCalle.Bindear(Nuevo, "Cli_Dom_Calle");
            boxNumero.Bindear(Nuevo, "Cli_Nro_Calle");
            boxPiso.Bindear(Nuevo, "Cli_Piso");
            boxDepartamento.Bindear(Nuevo, "Cli_Depto");
            boxCodigoPostal.Bindear(Nuevo, "Cli_Cod_Postal");
            boxLocalidad.Bindear(Nuevo, "Cli_Localidad");
        }

    }
}
