using PalcoNet.Model;
using System;
using System.Collections;
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
    public partial class GenerarPublicacionForm : Form
    {
        List<Ubicacion> Ubicaciones = new List<Ubicacion>();

        public GenerarPublicacionForm() {
            InitializeComponent();
            boxHora.Format = DateTimePickerFormat.Time;
            boxHora.ShowUpDown = false;
        }
        
        private void botonAgregarFecha_Click(object sender, EventArgs e) {
            var item = new FechaHoraModel();
            var f = boxFecha.Value;
            var h = boxHora.Value;
            item.Fecha = f.ToLongDateString();
            item.Hora = h.ToShortTimeString();
            item.Valor = new DateTime(f.Year, f.Month, f.Day, h.Hour, h.Minute, h.Second);
            fechaHoraModelBindingSource.Add(item);
            int i = gridFechasHoras.Rows.GetLastRow(DataGridViewElementStates.None);
            gridFechasHoras.Rows[i].Cells["botonBorrar"].Value = "X";
        }

        private void gridFechasHoras_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                fechaHoraModelBindingSource.RemoveAt(e.RowIndex);
        }

        private void gridUbicaciones_SelectionChanged(object sender, EventArgs e) {
            gridUbicaciones.ClearSelection();
        }

        private void gridFechasHoras_SelectionChanged(object sender, EventArgs e) {
            gridFechasHoras.ClearSelection();
        }

        private void botonAgregarUbicacion_Click(object sender, EventArgs e) {
            var ubicacion = new Ubicacion
            {
                Ubicacion_Asiento = decimal.Parse(boxAsiento.Text),
                Ubicacion_Fila = boxFila.Text,
                Ubicacion_Precio = decimal.Parse(boxPrecio.Text),
                Ubicacion_Sin_numerar = checkSinEnumerar.Checked,
                Ubicacion_Tipo = boxTipo.Text
                //agregar la publicacion cuando se creen las publicaciones
            };
            if (UbicacionValida(ubicacion.Ubicacion_Fila, ubicacion.Ubicacion_Asiento)) {
                ubicacionBindingSource.Add(ubicacion);
                Ubicaciones.Add(ubicacion);
                int i = gridUbicaciones.Rows.GetLastRow(DataGridViewElementStates.None);
                gridUbicaciones.Rows[i].Cells["BorrarUbicacion"].Value = "X";
            }
            else
            {
                MessageBox.Show("Ya existe esa combinación fila/asiento");
            }
        }

        private bool UbicacionValida(string fila, decimal asiento) {
            return Ubicaciones.All(u => u.Ubicacion_Fila != fila || u.Ubicacion_Asiento != asiento);
        }

        private void gridUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                ubicacionBindingSource.RemoveAt(e.RowIndex);
        }
    }
}
