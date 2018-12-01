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
    public partial class RolesForm : Form
    {
        private Rol Seleccionado;
        private DataGridViewRow FilaSeleccionada;

        public RolesForm() {
            InitializeComponent();

            using (var context = new GD2C2018Entities())
            {
                rolBindingSource.DataSource = context.Rol.ToList();
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e) {
            new NuevoRolForm(dataGrid).Show();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e) {
            if (dataGrid.SelectedRows.Count > 0)
            {
                Seleccionado = dataGrid.SelectedRows[0].DataBoundItem as Rol;
                botonModificar.Enabled = true;
                botonEliminar.Enabled = true;
            }
        }

        private void botonModificar_Click(object sender, EventArgs e) {
            MessageBox.Show("IMPLEMENTAR (O NO ::)))) )");
            FilaSeleccionada = dataGrid.SelectedRows[0];
        }

        private void botonEliminar_Click(object sender, EventArgs e) {
            var selected = dataGrid.SelectedRows[0];
            var nombre = selected.Cells[0].Value.ToString() + " ("
                        + selected.Cells[1].Value.ToString() + ")";
            string mensaje = "¿Está seguro que desea eliminar al rol " + nombre + "?";
            DialogResult result = MessageBox.Show(mensaje, "Borrar rol", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                BorrarRol(selected.Index);
        }

        private void BorrarRol(int fila) {
            
            using (var context = new GD2C2018Entities())
            {
                Seleccionado.Rol_Habilitado = false;
                context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                ActualizarColor(Seleccionado);
                //dataGrid.DataSource = rolBindingSource;
            }
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                var rol = row.DataBoundItem as Rol;
                if (!rol.Rol_Habilitado.Value)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
            }
        }

        //Metodo llamado luego de modificar, para cambiar color
        public void ActualizarColor(Rol r) {
            FilaSeleccionada.DefaultCellStyle.BackColor = r.Rol_Habilitado.Value ?
                Color.White : Color.FromArgb(255, 230, 230);
        }

        private void RolesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }
    }
}
