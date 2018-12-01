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

        public GradosForm() {
            InitializeComponent();

            using (var context = new GD2C2018Entities())
            {
                gradoPublicacionBindingSource.DataSource = context.Grado_Publicacion.ToList();
            }

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            new AltaGrado(datagrid).Show();
        }
        private void botonModificar_Click(object sender, EventArgs e)
        {
            new ModificacionGradoForm(Seleccionado).Show(this);
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
            using (var context = new GD2C2018Entities())
            {
                Seleccionado.Grado_Habilitado = false;
                context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                ActualizarColor(Seleccionado);
                //datagrid.DataSource = gradoPublicacionBindingSource;
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (var context = new GD2C2018Entities())
            {
                var query = from grado in context.Grado_Publicacion
                            where grado.Grado_Nombre.Contains(boxFiltroNombre.Text)
                            select grado;
                gradoPublicacionBindingSource.DataSource = query.ToList();
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            boxFiltroNombre.Text = "";
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
    }
}
