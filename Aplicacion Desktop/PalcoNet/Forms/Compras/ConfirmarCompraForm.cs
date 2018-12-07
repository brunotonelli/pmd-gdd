using PalcoNet.Extensiones;
using PalcoNet.Model;
using PalcoNet.Validaciones;
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
            boxFormaPago.SelectedItem = boxFormaPago.Items[0];
            boxFecha.Value = Configuracion.FechaActual;
            sourceUbicaciones.DataSource = GetUbicaciones();
            botonSeleccionar.Enabled = sourceUbicaciones.Count > 0;
        }


        private List<UbicacionModel> GetUbicaciones() {
            using (var context = new GD2C2018Entities())
            {
                var a = context.Ubicacion.Count();
                return (from u in context.Ubicacion
                        where u.Ubicacion_Publicacion == Publicacion.ID
                        select new UbicacionModel
                        {
                            Publicacion = u.Ubicacion_Publicacion,
                            Asiento = u.Ubicacion_Asiento,
                            Fila = u.Ubicacion_Fila,
                            Enumerado = u.Ubicacion_Sin_numerar.Value ? "NO" : "SÍ",
                            Precio = u.Ubicacion_Precio,
                            Tipo = u.Ubicacion_Tipo,
                            Disponible = u.Ubicacion_Disponible
                        }).ToList();
            }
        }

        private void botonSeleccionar_Click(object sender, EventArgs e) {
            var u = dataGrid.SelectedRows[0].DataBoundItem as UbicacionModel;
            if (u.Disponible)
            {
                sourceSeleccionados.Add(u);
                sourceUbicaciones.Remove(u);
                botonSeleccionar.Enabled = sourceUbicaciones.Count > 0;
                botonDeseleccionar.Enabled = sourceSeleccionados.Count > 0;
                Cantidad++;
                Total += u.Precio;
                labelCantidad.Text = Cantidad.ToString();
                labelTotal.Text = "$ " + Total.ToString();
                ActualizarPuntos();
            }
            else
            {
                MessageBox.Show("Ese asiento ya se encuentra ocupado", "Error", MessageBoxButtons.OK);
            }
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
            ActualizarPuntos();
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
                Compra compra = GetCompra(context);
                context.Entry(compra).State = System.Data.Entity.EntityState.Added;
                GuardarUbicaciones(context);
                GuardarPuntos(context, compra.Compra_Fecha);
                context.SaveChanges();
            }
            MessageBox.Show("La empresa de espectaculos le enviará la factura", "Compra realizada con éxito", MessageBoxButtons.OK);
            this.Close();
        }

        private void dataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                UbicacionModel ubic = row.DataBoundItem as UbicacionModel;
                if (ubic.Disponible) row.DefaultCellStyle.BackColor = Color.FromArgb(230, 255, 230);
                else row.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
            }
        }

        private void GuardarUbicaciones(GD2C2018Entities context) {
            foreach (UbicacionModel u in sourceSeleccionados.List)
            {
                var ubicacion = (from ub in context.Ubicacion
                                 where ub.Ubicacion_Publicacion == Publicacion.ID
                                 && ub.Ubicacion_Asiento == u.Asiento
                                 && ub.Ubicacion_Fila == u.Fila
                                 select ub).FirstOrDefault();
                ubicacion.Ubicacion_Disponible = false;
                context.Entry(ubicacion).State = System.Data.Entity.EntityState.Modified;
            }
        }

        private void GuardarPuntos(GD2C2018Entities context, DateTime fecha) {
            Puntos puntos = new Puntos
            {
                Puntos_Cantidad = (int)(Total * 0.35m),
                Puntos_Tipo_Doc_Cliente = Sesion.Cliente.Cli_Tipo_Doc,
                Puntos_Num_Doc_Cliente = Sesion.Cliente.Cli_Nro_Doc,
                Puntos_Vencimiento = fecha.AddMonths(6)
            };
            context.Entry(puntos).State = System.Data.Entity.EntityState.Added;
        }

        private void ActualizarPuntos() {
            labelPuntos.Text = ((int)(Total * 0.35m)).ToString();
        }

        private Compra GetCompra(GD2C2018Entities context) {
            return new Compra
            {
                Compra_Fecha = Configuracion.FechaActual,
                Compra_Cantidad = Cantidad,
                Compra_Forma_Pago = boxFormaPago.SelectedItem.ToString(),
                Compra_Tipo_Doc_Cliente = Sesion.Cliente.Cli_Tipo_Doc,
                Compra_Num_Doc_Cliente = Sesion.Cliente.Cli_Nro_Doc,
                Compra_Total = Total,
                Compra_Publicacion = Publicacion.ID,
                Compra_Facturada = false
            };
        }
    }
}
