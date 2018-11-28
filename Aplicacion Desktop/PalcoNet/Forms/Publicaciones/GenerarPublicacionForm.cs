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
    public partial class GenerarPublicacionForm : Form
    {
        public GenerarPublicacionForm() {
            InitializeComponent();
            boxHora.Format = DateTimePickerFormat.Time;
            boxHora.ShowUpDown = false;
        }

        private void botonAgregarUbicacion_Click(object sender, EventArgs e) {
            var ejemplo = new Ubicacion
            {
                Ubicacion_Fila = "A",
                Ubicacion_Asiento = 1,
                Ubicacion_Precio = 100,
                Ubicacion_Sin_numerar = true,
                Ubicacion_Tipo = "Campo"
            };
            ubicacionBindingSource.Add(ejemplo);
        }

        private void botonEliminarUbicacion_Click(object sender, EventArgs e) {
            var row = gridUbicaciones.SelectedRows[0];
            var u = row.DataBoundItem as Ubicacion;
            ubicacionBindingSource.Remove(u);
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
            gridFechasHoras.Rows[i].Cells["botonBorrar"].Value = "BORRAR";
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
    }
}
