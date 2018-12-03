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
    public partial class EditarPublicacionForm : Form
    {
        Publicacion Publicacion;
        Espectaculo Espectaculo;
        List<Ubicacion> Ubicaciones = new List<Ubicacion>();
        GD2C2018Entities context = new GD2C2018Entities();

        public EditarPublicacionForm(Publicacion publicacion) {
            InitializeComponent();
            Publicacion = publicacion;
            Espectaculo = ConsultasDB.GetEspectaculo(publicacion.Publicacion_Espectaculo);
            CargarComboBox();
        }

        private void CargarDatos() {
            boxHora.Format = DateTimePickerFormat.Time;
            boxHora.ShowUpDown = true;
            boxEmpresa.Text = ConsultasDB.GetEmpresa(Publicacion.Publicacion_Empresa).Espec_Empresa_Razon_Social;
        }
        
        private void CargarComboBox() {
            boxEstado.SelectedItem = ConsultasDB.GetEstado(Publicacion.Publicacion_Estado).Estado_Descripcion;
            foreach (var rubro in context.Rubro)
                boxRubro.Items.Add(rubro.Rubro_Descripcion);
            foreach (var grado in context.Grado_Publicacion)
                boxGrado.Items.Add(grado.Grado_Nombre);
            boxRubro.SelectedItem = Espectaculo.Espectaculo_Rubro;
            boxGrado.SelectedItem = ConsultasDB.GetGrado(Publicacion.Publicacion_Grado.Value).Grado_Nombre;
        }

        private void botonAgregarUbicacion_Click(object sender, EventArgs e) {
            var ubicacion = new Ubicacion
            {
                Ubicacion_Asiento = decimal.Parse(boxAsiento.Text),
                Ubicacion_Fila = boxFila.Text,
                Ubicacion_Precio = decimal.Parse(boxPrecio.Text),
                Ubicacion_Sin_numerar = checkSinEnumerar.Checked,
                Ubicacion_Tipo = boxTipo.Text,
                Ubicacion_Disponible = true
            };
            if (UbicacionValida(ubicacion.Ubicacion_Fila, ubicacion.Ubicacion_Asiento))
            {
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
            {
                var u = Ubicaciones.ElementAt(e.RowIndex);
                if (u.Ubicacion_Disponible)
                {
                    ubicacionBindingSource.RemoveAt(e.RowIndex);
                    Ubicaciones.RemoveAt(e.RowIndex);
                }
                else
                {
                    string mensaje = string.Format("El asiento {0} en fila {1} ya está comprado, no lo puede eliminar", u.Ubicacion_Asiento, u.Ubicacion_Fila);
                    MessageBox.Show(mensaje, "Error");
                }
                
            }
        }
    }
}
