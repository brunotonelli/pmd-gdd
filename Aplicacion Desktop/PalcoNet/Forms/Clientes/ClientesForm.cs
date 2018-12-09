using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Extensiones;

namespace PalcoNet.Forms
{
    public partial class ClientesForm : Form
    {
        private Cliente Seleccionado;
        private DataGridViewRow FilaSeleccionada;
        GD2C2018Entities context = new GD2C2018Entities();

        public ClientesForm() {
            InitializeComponent();
            clienteBindingSource.DataSource = context.Cliente.ToList();
        }

        private void botonNuevo_Click(object sender, EventArgs e) {
            new AltaClientesForm(dataGrid).Show();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e) {
            if (dataGrid.SelectedRows.Count > 0)
            {
                Seleccionado =  dataGrid.SelectedRows[0].DataBoundItem as Cliente;
                botonModificar.Enabled = true;
                botonEliminar.Enabled = true;
            }
        }
        
        private void botonModificar_Click(object sender, EventArgs e) {
            new ModifClientesForm(Seleccionado).Show(this);
            FilaSeleccionada = dataGrid.SelectedRows[0];
        }

        private void botonEliminar_Click(object sender, EventArgs e) {
            FilaSeleccionada = dataGrid.SelectedRows[0];
            var c = FilaSeleccionada.DataBoundItem as Cliente;
            var nombre = c.Cli_Nombre + " " + c.Cli_Apellido;
            string mensaje = "¿Está seguro que desea eliminar (de forma lógica) al cliente " + nombre + "?";
            DialogResult result = MessageBox.Show(mensaje, "Borrar cliente", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                BorrarCliente();
        }

        private void BorrarCliente() {
            using (var context = new GD2C2018Entities())
            {
                Seleccionado.Cli_Habilitado = false;
                context.Entry(Seleccionado).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                ActualizarColor(Seleccionado);
                //dataGrid.DataSource = clienteBindingSource;
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e) {
            var query = from cliente in context.Cliente
                        where cliente.Cli_Nombre.Contains(boxFiltroNombre.Text) &&
                              cliente.Cli_Apellido.Contains(boxFiltroApellido.Text) &&
                              cliente.Cli_Mail.Contains(boxFiltroMail.Text)
                        select cliente;
            if (boxFiltroDNI.Text.Length > 0)
            {
                decimal documento = decimal.Parse(boxFiltroDNI.Text);
                query = query.Where(cliente => cliente.Cli_Nro_Doc == documento);
            }
            clienteBindingSource.DataSource = query.ToList();
        }

        private void botonLimpiar_Click(object sender, EventArgs e) {
            boxFiltroNombre.Text = string.Empty;
            boxFiltroApellido.Text = string.Empty;
            boxFiltroDNI.Text = string.Empty;
            boxFiltroMail.Text = string.Empty;
            clienteBindingSource.DataSource = context.Cliente.ToList();
        }
                
        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                var cliente = row.DataBoundItem as Cliente;
                if (!cliente.Cli_Habilitado)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
            }
        }

        //Metodo llamado luego de modificar, para cambiar color
        public void ActualizarColor(Cliente c) {
            FilaSeleccionada.DefaultCellStyle.BackColor = c.Cli_Habilitado ?
                Color.White : Color.FromArgb(255, 230, 230);
        }

        private void ClientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }
    }
}
