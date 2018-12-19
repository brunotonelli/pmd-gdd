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
    public partial class EmpresasForm : Form
    {
        private Espec_Empresa Seleccionado;
        private DataGridViewRow FilaSeleccionada;
        GD2C2018Entities Context = new GD2C2018Entities();

        public EmpresasForm(){
            InitializeComponent();
            ActualizarGrid();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e){
            if (dataGrid.SelectedRows.Count > 0)
            {
                Seleccionado = dataGrid.SelectedRows[0].DataBoundItem as Espec_Empresa;
                botonEliminar.Enabled = true;
                botonModificar.Enabled = true;
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e){
            new AltaEmpresaForm(Context).Show(this);
        }

        public void ActualizarGrid()
        {
            especEmpresaBindingSource.DataSource = Context.Espec_Empresa.ToList();
        }
        
        private void botonModificar_Click(object sender, EventArgs e){
            new ModifEmpresasForm(Seleccionado, Context).Show(this);
            FilaSeleccionada = dataGrid.SelectedRows[0];
        }

       private void botonEliminar_Click(object sender, EventArgs e) {
            FilaSeleccionada = dataGrid.SelectedRows[0];
            var emp = FilaSeleccionada.DataBoundItem as Espec_Empresa;
            var razon = emp.Espec_Empresa_Razon_Social;
            string mensaje = "¿Está seguro que desea eliminar (de forma lógica) a la Empresa " + razon + "?";
            DialogResult result = MessageBox.Show(mensaje, "Borrar Empresa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                BorrarEmpresa();
        }

        private void BorrarEmpresa() {
            Seleccionado.Espec_Empresa_Habilitado = false;
            Context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            ActualizarColor(Seleccionado);
        }

        private void botonBuscar_Click(object sender, EventArgs e) {
            var query = from esp in Context.Espec_Empresa
                        where esp.Espec_Empresa_Razon_Social.Contains(boxFiltroRazon.Text) &&
                              esp.Espec_Empresa_Cuit.Contains(boxFiltroCUIT.Text) &&
                              esp.Espec_Empresa_Mail.Contains(boxFiltroMail.Text)
                        select esp;
            especEmpresaBindingSource.DataSource = query.ToList();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            boxFiltroCUIT.Text = string.Empty;
            boxFiltroMail.Text = string.Empty;
            boxFiltroRazon.Text = string.Empty;
            using (var context = new GD2C2018Entities())
            {
                especEmpresaBindingSource.DataSource = (from esp in context.Espec_Empresa
                                                        select esp).ToList();
            }
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                var empresa = row.DataBoundItem as Espec_Empresa;
                var hab = empresa.Espec_Empresa_Habilitado ?? true;
                if (!hab)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
            }
        }

        //Metodo llamado luego de modificar, para cambiar color
        public void ActualizarColor(Espec_Empresa e) {
            FilaSeleccionada.DefaultCellStyle.BackColor = e.Espec_Empresa_Habilitado.Value ?
                Color.White : Color.FromArgb(255, 230, 230);
        }

        private void EmpresasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }
    }
}
