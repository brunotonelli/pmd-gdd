using PalcoNet.Extensiones;
using PalcoNet.Model;
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
    public partial class ConfirmarCompraForm : Form
    {
        PublicacionModel Publicacion;
        int Cantidad = 0;
        decimal Total = 0;

        public ConfirmarCompraForm(PublicacionModel publicacion) {
            InitializeComponent();
            Publicacion = publicacion;
            CargarFormasDePago();
            boxFecha.Value = Properties.Settings.Default.FechaActual;
            sourceUbicaciones.DataSource = GetUbicaciones();
            botonSeleccionar.Enabled = sourceUbicaciones.Count > 0;
        }

        private void CargarFormasDePago() {
            using (var context = new GD2C2018Entities())
            {
                boxFormaPago.Items.Clear();
                var q = (from f in context.Forma_Pago
                         select f.Forma_Pago_Desc).ToList();
                foreach (var f in q)
                    boxFormaPago.Items.Add(f);
                boxFormaPago.SelectedItem = boxFormaPago.Items[0];
            }
        }

        private List<UbicacionModel> GetUbicaciones() {
            using (var context = new GD2C2018Entities())
            {
                var a = context.Ubicacion.Count();
                return (from u in context.Ubicacion
                        join t in context.Tipo_Ubicacion on u.Ubicacion_Tipo equals t.Tipo_Ubicacion_Codigo
                        where u.Ubicacion_Publicacion == Publicacion.ID
                        select new UbicacionModel
                        {
                            Publicacion = u.Ubicacion_Publicacion,
                            Asiento = u.Ubicacion_Asiento,
                            Fila = u.Ubicacion_Fila,
                            Enumerado = u.Ubicacion_Sin_numerar.Value ? "NO" : "SÍ",
                            Precio = u.Ubicacion_Precio,
                            Tipo = t.Tipo_Ubicacion_Descripcion,
                            Disponible = u.Ubicacion_Disponible
                        }).ToList();
            }
        }

        private void botonSeleccionar_Click(object sender, EventArgs e) {
            var u = dataGrid.SelectedRows[0].DataBoundItem as UbicacionModel;
            sourceSeleccionados.Add(u);
            sourceUbicaciones.Remove(u);
            botonSeleccionar.Enabled = sourceUbicaciones.Count > 0;
            botonDeseleccionar.Enabled = sourceSeleccionados.Count > 0;
            Cantidad++;
            Total += u.Precio;
            labelCantidad.Text = Cantidad.ToString();
            labelTotal.Text = "$ " + Total.ToString();
        }

        private void botonDeseleccionar_Click(object sender, EventArgs e) {
            var u = gridSeleccionados.SelectedRows[0].DataBoundItem as UbicacionModel;
            sourceUbicaciones.Add(u);
            sourceSeleccionados.Remove(u);
            botonSeleccionar.Enabled = sourceUbicaciones.Count > 0;
            botonDeseleccionar.Enabled = sourceSeleccionados.Count > 0;
            Cantidad--;
            Total -= u.Precio;
            labelCantidad.Text = Cantidad.ToString();
            labelTotal.Text = "$ " + Total.ToString();
        }

        private void botonConfirmar_Click(object sender, EventArgs e) {
            string mensaje = string.Format("¿Desea confirmar la compra de las {0} ubicaciones seleccionadas?", Cantidad);
            DialogResult ok = MessageBox.Show(mensaje, "Confirmar compra", MessageBoxButtons.YesNo);
            if (ok == DialogResult.Yes)
                ConfirmarCompra();
        }

        private void ConfirmarCompra() {
            
            using (var context = new GD2C2018Entities())
            {
                var cliente = (from c in context.Cliente
                                  where c.Cli_Usuario == InfoSesion.Usuario.Usuario_Username
                                  select new
                                  {
                                      tipo = c.Cli_Tipo_Doc,
                                      numero = c.Cli_Nro_Doc
                                  }).FirstOrDefault();
                if (cliente == null)
                    cliente = new { tipo = "DNI", numero = 0.0m };

                int formaPago = (from f in context.Forma_Pago
                                 where f.Forma_Pago_Desc == boxFormaPago.SelectedItem.ToString()
                                 select f.Forma_Pago_ID).First();

                Compra compra = new Compra
                {
                    Compra_Fecha = Properties.Settings.Default.FechaActual,
                    Compra_Cantidad = Cantidad,
                    Compra_Forma_Pago = formaPago,
                    Compra_Tipo_Doc_Cliente = cliente.tipo,
                    Compra_Num_Doc_Cliente = cliente.numero,
                    Compra_Total = Total
                };

                context.Entry(compra).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }

            MessageBox.Show("La empresa de espectaculos le enviará la factura", "Compra realizada con éxito", MessageBoxButtons.OK);
            this.Close();
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                UbicacionModel ubic = row.DataBoundItem as UbicacionModel;
                if (!ubic.Disponible) row.DefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200);
                else row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
            }
        }
    }
}
