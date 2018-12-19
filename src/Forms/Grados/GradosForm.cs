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
    public partial class GradosForm : Form
    {
        private int id;
        private Grado_Publicacion Seleccionado;
        private DataGridViewRow FilaSeleccionada;
        GD2C2018Entities Context = new GD2C2018Entities();

        public GradosForm() {
            InitializeComponent();
            ActualizarGrid();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            new AltaGrado(Context).Show(this);
        }
        private void botonModificar_Click(object sender, EventArgs e)
        {
            new ModificacionGradoForm(Seleccionado, Context).Show(this);
            FilaSeleccionada = datagrid.SelectedRows[0];
        }
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            FilaSeleccionada = datagrid.SelectedRows[0];
            var grado = FilaSeleccionada.DataBoundItem as Grado_Publicacion;
            var nombre = grado.Grado_Nombre;
            string mensaje = "¿Está seguro que desea eliminar (de forma lógica) el grado " + nombre + "?";
            DialogResult result = MessageBox.Show(mensaje, "Borrar grado de publicacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                BorrarGrado();
        }

        private void BorrarGrado()
        {
            Seleccionado.Grado_Habilitado = false;
            Context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            ActualizarColor(Seleccionado);
        }
        
        private void datagrid_SelectionChanged_1(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                Seleccionado = datagrid.SelectedRows[0].DataBoundItem as Grado_Publicacion;
                botonModificar.Enabled = true;
            }
            botonEliminar.Enabled = Seleccionado.Grado_Habilitado.Value;
        }

        private void datagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewRow row in datagrid.Rows)
            {
                var grado = row.DataBoundItem as Grado_Publicacion;
                if (!grado.Grado_Habilitado.Value)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
            }
        }

        //Metodo llamado luego de modificar, para cambiar color
        public void ActualizarColor(Grado_Publicacion g) {
            FilaSeleccionada.DefaultCellStyle.BackColor = g.Grado_Habilitado.Value ?
                Color.White : Color.FromArgb(255, 230, 230);
        }

        private void GradosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }

        public void ActualizarGrid()
        {
            gradoPublicacionBindingSource.DataSource = Context.Grado_Publicacion.ToList();
        }
    }
}
