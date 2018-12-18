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
        GD2C2018Entities context = new GD2C2018Entities();

        public RolesForm() {
            InitializeComponent();
            rolBindingSource.DataSource = context.Rol.ToList();
        }

        private void botonNuevo_Click(object sender, EventArgs e) {
            new NuevoRolForm().Show(this);
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
            new EditarRolForm(Seleccionado, context).Show(this);
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
            FilaSeleccionada = dataGrid.SelectedRows[0];
            Seleccionado.Rol_Habilitado = false;
            var usuariosConRol = (from u in context.Usuario
                                  where u.Rol.Any(r => r.Rol_ID == Seleccionado.Rol_ID)
                                  select u).ToList();
            int afectados = usuariosConRol.Count();
            usuariosConRol.ForEach(u => u.Rol.Remove(Seleccionado));
            context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            ActualizarColores();
            string mensaje = string.Format("Se han afectado {0} usuarios.", afectados);
            MessageBox.Show(mensaje, "Rol inhabilitado");
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            ActualizarColores();
        }

        //Metodo llamado luego de modificar/nuevo, para cambiar color
        public void ActualizarColores() {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                var rol = row.DataBoundItem as Rol;
                row.DefaultCellStyle.BackColor = rol.Rol_Habilitado.Value ?
                Color.White : Color.FromArgb(255, 230, 230);
            }
        }

        private void RolesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }

        public void ActualizarGrid()
        {
            rolBindingSource.DataSource = context.Rol.ToList();
            ActualizarColores();
        }
    }
}
