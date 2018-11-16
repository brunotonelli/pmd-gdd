using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Forms.Clientes
{
    public partial class ClientesForm : Form
    {
        public ClientesForm() {
            InitializeComponent();

            using (var context = new GD2C2018Entities())
            {
                var query = from cliente in context.Cliente
                            select cliente;
                clienteBindingSource.DataSource = query.ToList().Take(10);
            }

        }

        private void botonNuevo_Click(object sender, EventArgs e) {
            new AltaClientesForm().Show();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e) {
            botonDetalles.Enabled = true;
            botonModificar.Enabled = true;
            botonEliminar.Enabled = true;
        }

        private void botonDetalles_Click(object sender, EventArgs e) {

        }

        private void botonModificar_Click(object sender, EventArgs e) {

        }

        private void botonEliminar_Click(object sender, EventArgs e) {
            var selected = dataGrid.SelectedRows[0];
            var nombre = selected.Cells[0].Value.ToString() + " " 
                        + selected.Cells[1].Value.ToString();
            string mensaje = "¿Está seguro que desea eliminar al cliente " + nombre + "?";
            DialogResult result = MessageBox.Show(mensaje, "Borrar cliente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                BorrarCliente(selected);
        }

        private void BorrarCliente(DataGridViewRow fila) {

            decimal dni = Decimal.Parse(fila.Cells[2].Value.ToString());
            dataGrid.Rows.Remove(fila); //visualmente saco la fila
            
            using (var context = new GD2C2018Entities())
            {
                var cliente = new Cliente { Cli_Dni = dni };
                context.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
