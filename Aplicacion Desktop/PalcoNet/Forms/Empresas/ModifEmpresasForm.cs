﻿using PalcoNet.Extensiones;
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


namespace PalcoNet.Forms.Empresas
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
            BindearCampos();

            boxRazon.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxCUIT.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
     

        }

        private void BindearCampos()
        {
            boxCUIT.Bindear(Seleccionado, "Espec_Empresa_Cuit");
            boxRazon.Bindear(Seleccionado, "Espec_Empresa_Razon_Social");
            boxMail.Bindear(Seleccionado, "Espec_Empresa_Mail");
            boxTelefono.Bindear(Seleccionado, "Espec_Empresa_Telefono");
            boxCalle.Bindear(Seleccionado, "Espec_Empresa_Dom_Calle");
            boxNumero.Bindear(Seleccionado, "Espec_Empresa_Nro_Calle");
            boxPiso.Bindear(Seleccionado, "Espec_Empresa_Piso");
            boxDepartamento.Bindear(Seleccionado, "Espec_Empresa_Depto");
            boxCodigoPostal.Bindear(Seleccionado, "Espec_Empresa_Cod_Postal");
            boxLocalidad.Bindear(Seleccionado, "Espec_Empresa_Localidad");
            boxCiudad.Bindear(Seleccionado, "Espec_Empresa_Ciudad");
        }


        private void ValidarRequeridos(object sender, EventArgs e)
        {
            var cuit = boxCUIT.Text;
            var razon = boxRazon.Text;
            var mail = boxMail.Text;
            bool ok = cuit.Length != 0 && razon.Length != 0 && mail.Length != 0;

            botonGuardar.Enabled = ok;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new GD2C2018Entities())
            {
                var empresa = context.Espec_Empresa.Single(em => em.Espec_Empresa_Cuit == Cuit);

                context.Entry(empresa).CurrentValues.SetValues(Seleccionado);
                context.SaveChanges();
            }
            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    }
}