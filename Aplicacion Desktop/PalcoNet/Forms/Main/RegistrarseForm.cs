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
    public partial class RegistrarseForm : Form
    {
        public RegistrarseForm()
        {
            InitializeComponent();
        }

        private void botonEmpresa_Click(object sender, EventArgs e)
        {
            if (ConsultasDB.GetRol("EMP").Rol_Habilitado.Value)
                new RegistrarEmpresaForm().Show();
            else
                MessageBox.Show("Las empresas (el rol) fue deshabilitado.\nContacte a un admin para resolver el problema");
        }

        private void botonCliente_Click(object sender, EventArgs e)
        {
            if (ConsultasDB.GetRol("CLI").Rol_Habilitado.Value)
                new RegistrarClienteForm().Show();
            else
                MessageBox.Show("Los clientes (el rol) fue deshabilitado.\nContacte a un admin para resolver el problema");
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();       
        }
    }
}
