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
            sourceUbicaciones.DataSource = GetUbicaciones();
            botonSeleccionar.Enabled = sourceUbicaciones.Count > 0;
        }

        private List<UbicacionModel> GetUbicaciones() {
            using (var context = new GD2C2018Entities())
            {
                return (from u in context.Ubicacion
                        join t in context.Tipo_Ubicacion on u.Ubicacion_Tipo equals t.Tipo_Ubicacion_Codigo
                        select new UbicacionModel
                        {
                            Publicacion = u.Ubicacion_Publicacion,
                            Asiento = u.Ubicacion_Asiento,
                            Fila = u.Ubicacion_Fila,
                            Enumerado = u.Ubicacion_Sin_numerar.Value ? "NO" : "SÍ",
                            Precio = u.Ubicacion_Precio ?? 0,
                            Tipo = t.Tipo_Ubicacion_Descripcion
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
    }
}
