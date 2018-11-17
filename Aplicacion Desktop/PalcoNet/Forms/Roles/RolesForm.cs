using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Forms.Roles
{
    public partial class RolesForm : Form
    {
        private Rol Seleccionado;

        public RolesForm() {
            InitializeComponent();

            using (var context = new GD2C2018Entities())
            {
                var query = from rol in context.Rol
                            select rol;
                rolBindingSource.DataSource = query.ToList();
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e) {
            new NuevoRolForm().Show();
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

            dataGrid.Rows.RemoveAt(fila); //visualmente saco la fila

            using (var context = new GD2C2018Entities())
            {
                context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
