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
    public partial class ClientesForm : Form
    {
        private Cliente Seleccionado;

        public ClientesForm() {
            InitializeComponent();

            using (var context = new GD2C2018Entities())
            {
                clienteBindingSource.DataSource = context.Cliente.ToList();
            }

        }

        private void botonNuevo_Click(object sender, EventArgs e) {
            new AltaClientesForm(dataGrid).Show();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e) {
            if (dataGrid.SelectedRows.Count > 0)
            {
                Seleccionado =  dataGrid.SelectedRows[0].DataBoundItem as Cliente;
                botonDetalles.Enabled = true;
                botonModificar.Enabled = true;
                botonEliminar.Enabled = true;
            }
        }

        private void botonDetalles_Click(object sender, EventArgs e) {

        }

        private void botonModificar_Click(object sender, EventArgs e) {
            new ModifClientesForm(Seleccionado).Show();
        }

        private void botonEliminar_Click(object sender, EventArgs e) {
            var selected = dataGrid.SelectedRows[0];
            var nombre = selected.Cells[0].Value.ToString() + " " 
                        + selected.Cells[1].Value.ToString();
            string mensaje = "¿Está seguro que desea eliminar al cliente " + nombre + "?";
            DialogResult result = MessageBox.Show(mensaje, "Borrar cliente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                BorrarCliente(selected.Index);
        }

        private void BorrarCliente(int fila) {
            using (var context = new GD2C2018Entities())
            {
                context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                clienteBindingSource.Remove(Seleccionado);
                dataGrid.DataSource = clienteBindingSource;
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e) {
            using (var context = new GD2C2018Entities())
            {
                var query = from cliente in context.Cliente
                            where cliente.Cli_Nombre.Contains(boxFiltroNombre.Text) &&
                                  cliente.Cli_Apellido.Contains(boxFiltroApellido.Text) &&
                                  cliente.Cli_Mail.Contains(boxFiltroMail.Text)                                
                            select cliente;
                if (boxFiltroDNI.Text.Length > 0) {
                    decimal documento = decimal.Parse(boxFiltroDNI.Text);
                    query = query.Where(cliente => cliente.Cli_Nro_Doc == documento);
                }
                clienteBindingSource.DataSource = query.ToList();
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e) {
            boxFiltroNombre.Text = string.Empty;
            boxFiltroApellido.Text = string.Empty;
            boxFiltroDNI.Text = string.Empty;
            boxFiltroMail.Text = string.Empty;
            using (var context = new GD2C2018Entities())
            {
                clienteBindingSource.DataSource = (from cliente in context.Cliente
                                                   select cliente).ToList();
            }            
        }
    }
}
