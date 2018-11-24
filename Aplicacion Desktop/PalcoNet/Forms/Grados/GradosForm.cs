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
            new ModificacionGradoForm(Seleccionado).Show();
        }
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            var selected = datagrid.SelectedRows[0];
            var nombre = selected.Cells[0].Value.ToString() + " "
                        + selected.Cells[1].Value.ToString();
            string mensaje = "¿Está seguro que desea eliminar este grado de publicacion" + nombre + "?";
            DialogResult result = MessageBox.Show(mensaje, "Borrar grado de publicacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                //BorrarGrado(selected.Index);
                BorrarGradoLogico(selected.Index);
        }

        private void BorrarGradoLogico(int fila)
        {
            using (var context = new GD2C2018Entities())
            {
                Seleccionado.Grado_Habilitado = false;
                id = Seleccionado.Grado_ID;
                var grado = context.Grado_Publicacion.Single(c => c.Grado_ID == id);
                context.Entry(grado).CurrentValues.SetValues(Seleccionado);
                context.SaveChanges();
                gradoPublicacionBindingSource.DataSource = context.Grado_Publicacion.ToList();
            }
        }

        private void BorrarGrado(int fila)
        {
            using (var context = new GD2C2018Entities())
            {
                context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                gradoPublicacionBindingSource.Remove(Seleccionado);
                datagrid.DataSource = gradoPublicacionBindingSource;
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
            if (Seleccionado.Grado_Habilitado == true)
            {
                btnHabilitar.Enabled = false;
                botonEliminar.Enabled = true;
            }
            else
            {
                btnHabilitar.Enabled = true;
                botonEliminar.Enabled = false;
            }

        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            using (var context = new GD2C2018Entities())
                {
                    Seleccionado.Grado_Habilitado = true;
                    id = Seleccionado.Grado_ID;
                    var grado = context.Grado_Publicacion.Single(c => c.Grado_ID == id);
                    context.Entry(grado).CurrentValues.SetValues(Seleccionado);
                    context.SaveChanges();
                    gradoPublicacionBindingSource.DataSource = context.Grado_Publicacion.ToList();
                }
            
        }
    }
}
