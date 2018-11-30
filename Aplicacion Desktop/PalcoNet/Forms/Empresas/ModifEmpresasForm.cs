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
    public partial class ModifEmpresasForm : Form
    {
        private Espec_Empresa Seleccionado;
        private string Cuit;

        public ModifEmpresasForm(Espec_Empresa empresa)
        {
            InitializeComponent();
            Cuit = empresa.Espec_Empresa_Cuit;
            Seleccionado = empresa;
            BindearCampos(Seleccionado);
            boxRazon.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxCUIT.TextChanged += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);  
        }
               
        private void ValidarRequeridos(object sender, EventArgs e)
        {
            var cuit = boxCUIT.Text;
            var razon = boxRazon.Text;
            var mail = boxMail.Text;
            bool ok = cuit.Length != 0 && razon.Length != 0 && mail.Length != 0;

            botonGuardar.Enabled = ok;
        }

        private void BindearCampos(Espec_Empresa e) {
            boxCiudad.Text = e.Espec_Empresa_Ciudad;
            boxCodigoPostal.Text = e.Espec_Empresa_Cod_Postal;
            boxCUIT.Text = e.Espec_Empresa_Cuit;
            boxDepartamento.Text = e.Espec_Empresa_Depto;
            boxCalle.Text = e.Espec_Empresa_Dom_Calle;
            checkHabilitado.Checked = e.Espec_Empresa_Habilitado.Value;
            boxLocalidad.Text = e.Espec_Empresa_Localidad;
            boxMail.Text = e.Espec_Empresa_Mail;
            boxNumero.Text = e.Espec_Empresa_Nro_Calle.ToString();
            boxPiso.Text = e.Espec_Empresa_Piso.ToString();
            boxRazon.Text = e.Espec_Empresa_Razon_Social;
            boxTelefono.Text = e.Espec_Empresa_Telefono;
        }

        private void BindearDatos() {
            Seleccionado.Espec_Empresa_Ciudad = boxCiudad.Text;
            Seleccionado.Espec_Empresa_Cod_Postal = boxCodigoPostal.Text;
            Seleccionado.Espec_Empresa_Cuit = boxCUIT.Text;
            Seleccionado.Espec_Empresa_Depto = boxDepartamento.Text;
            Seleccionado.Espec_Empresa_Dom_Calle = boxCalle.Text;
            Seleccionado.Espec_Empresa_Habilitado = checkHabilitado.Checked;
            Seleccionado.Espec_Empresa_Localidad = boxLocalidad.Text;
            Seleccionado.Espec_Empresa_Mail = boxMail.Text;
            Seleccionado.Espec_Empresa_Nro_Calle = decimal.Parse(boxNumero.Text);
            Seleccionado.Espec_Empresa_Piso = decimal.Parse(boxPiso.Text);
            Seleccionado.Espec_Empresa_Razon_Social = boxRazon.Text;
            Seleccionado.Espec_Empresa_Telefono = boxTelefono.Text;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            bool existeRazon = Validaciones.ExisteRazon(boxRazon.Text, boxCUIT.Text);

            bool cuitValido = Validaciones.CUILValido(boxCUIT.Text);

            if (existeRazon)
                MessageBox.Show("Ya existe una empresa con esa razón social", "Error de Empresa");
            if (!cuitValido)
                MessageBox.Show("El CUIL ingresado no tiene el formado correcto\nEjemplo: ##-########-#", "Error de CUIL");

            if (!existeRazon && cuitValido)
            {
                BindearDatos();
                using (var context = new GD2C2018Entities())
                {
                    var empresa = context.Espec_Empresa.Single(em => em.Espec_Empresa_Cuit == Cuit);

                    context.Entry(empresa).CurrentValues.SetValues(Seleccionado);
                    context.SaveChanges();
                    ((EmpresasForm)Owner).ActualizarColor(empresa);
                }
                this.Close();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    }
}
