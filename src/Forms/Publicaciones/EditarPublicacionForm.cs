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
using PalcoNet.Validaciones;

namespace PalcoNet.Forms
{
    public partial class EditarPublicacionForm : Form
    {
        Publicacion Publicacion;
        Espectaculo Espectaculo;
        bool GradoCambiado = false;

        List<Ubicacion> Ubicaciones = new List<Ubicacion>();
        List<Ubicacion> NuevasUbicaciones = new List<Ubicacion>();
        List<Ubicacion> BorradasUbicaciones = new List<Ubicacion>();

        GD2C2018Entities context = new GD2C2018Entities();

        public EditarPublicacionForm(Publicacion publicacion) {
            InitializeComponent();
            Publicacion = publicacion;
            AgregarEventosValidacion();
            Espectaculo = ConsultasDB.GetEspectaculo(publicacion.Publicacion_Espectaculo);
            CargarComboBox();
            CargarDatos();
        }

        private void CargarDatos() {
            boxHora.Format = DateTimePickerFormat.Time;
            boxHora.ShowUpDown = true;
            boxEmpresa.Text = ConsultasDB.GetEmpresa(Publicacion.Publicacion_Empresa).Espec_Empresa_Razon_Social;
            boxDescripcion.Text = Espectaculo.Espectaculo_Descripcion;
            boxFechaPublicacion.Value = Publicacion.Publicacion_Fecha;
            boxFecha.Value = Publicacion.Publicacion_Fecha_Espectaculo;
            boxHora.Value = Publicacion.Publicacion_Fecha_Espectaculo;
            boxRubro.SelectedItem = ConsultasDB.GetRubro(Espectaculo.Espectaculo_Rubro.Value).Rubro_Descripcion;
            boxGrado.SelectedItem = ConsultasDB.GetGrado(Publicacion.Publicacion_Grado.Value).Grado_Nombre;
            boxEstado.SelectedItem = ConsultasDB.GetEstado(Publicacion.Publicacion_Estado).Estado_Descripcion;
            boxDireccion.Text = Espectaculo.Espectaculo_Direccion;
            var query = from u in context.Ubicacion
                        where u.Ubicacion_Publicacion == Publicacion.Publicacion_ID
                        select u;
            Ubicaciones = query.ToList();
            ubicacionBindingSource.DataSource = query.ToList();
        }
        
        private void CargarComboBox() {
            foreach (var rubro in context.Rubro)
                boxRubro.Items.Add(rubro.Rubro_Descripcion);
            foreach (var grado in context.Grado_Publicacion)
                boxGrado.Items.Add(grado.Grado_Nombre);
        }

        private void botonAgregarUbicacion_Click(object sender, EventArgs e) {
            var ubicacion = new Ubicacion
            {
                Ubicacion_Asiento = decimal.Parse(boxAsiento.Text),
                Ubicacion_Fila = boxFila.Text,
                Ubicacion_Precio = decimal.Parse(boxPrecio.Text),
                Ubicacion_Sin_numerar = checkSinEnumerar.Checked,
                Ubicacion_Tipo = boxTipo.Text,
                Ubicacion_Disponible = true,
                Ubicacion_Publicacion = Publicacion.Publicacion_ID
            };
            if (UbicacionValida(ubicacion.Ubicacion_Fila, ubicacion.Ubicacion_Asiento))
            {
                
                ubicacionBindingSource.Add(ubicacion);
                Ubicaciones.Add(ubicacion);
                NuevasUbicaciones.Add(ubicacion);
                int i = gridUbicaciones.Rows.GetLastRow(DataGridViewElementStates.None);
                var row = gridUbicaciones.Rows[i];
                row.Cells["BorrarUbicacion"].Value = "X";
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
                    BorradasUbicaciones.Add(u);
                    Ubicaciones.RemoveAt(e.RowIndex);
                    ubicacionBindingSource.RemoveAt(e.RowIndex);
                }
                else
                {
                    string mensaje = string.Format("El asiento {0} en fila {1} ya está comprado, no lo puede eliminar", u.Ubicacion_Asiento, u.Ubicacion_Fila);
                    MessageBox.Show(mensaje, "Error");
                }
            }
        }

        private void gridUbicaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            foreach (var u in Ubicaciones)
            {
                int i = ubicacionBindingSource.IndexOf(u);
                var row = gridUbicaciones.Rows[i];
                row.Cells["BorrarUbicacion"].Value = "X";
                if (!u.Ubicacion_Disponible)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
            }
        }

        private void gridUbicaciones_SelectionChanged(object sender, EventArgs e) {
            gridUbicaciones.ClearSelection();
        }

        private void botonGuardar_Click(object sender, EventArgs e) {
            bool hayUbicaciones = Ubicaciones.Count() > 0;

            if (!hayUbicaciones)
                MessageBox.Show("No se ingresaron ubicaciones", "Error");
            else
            {

                Publicacion.Publicacion_Estado = ConsultasDB.GetEstado(boxEstado.Text);
                Publicacion.Publicacion_Fecha = boxFechaPublicacion.Value;
                Publicacion.Publicacion_Fecha_Espectaculo = boxFecha.Value;
                Publicacion.Publicacion_Grado = ConsultasDB.GetGrado(boxGrado.Text);
                Publicacion.Publicacion_Localidades = Ubicaciones.Count();

                context.Entry(Publicacion).State = System.Data.Entity.EntityState.Modified;

                foreach (var ubi in BorradasUbicaciones)
                {
                    context.Entry(ubi).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }

                foreach (var ubi in NuevasUbicaciones)
                {
                    context.Entry(ubi).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                }

                MessageBox.Show("Cambios guardados con éxito", "Guardar cambios");
                Owner.Show();
                this.Close();
            }
        }

        private void boxGrado_SelectedIndexChanged(object sender, EventArgs e) {
            if (GradoCambiado)
            {
                var grado = context.Grado_Publicacion.Single(g => g.Grado_Nombre == boxGrado.Text);
                string mensaje = string.Format("Ese grado cuesta una comisión del {0}%", grado.Grado_Comision);
                MessageBox.Show(mensaje, "Comisión por visibilidad", MessageBoxButtons.OK);
            }
            GradoCambiado = true;
        }

        private void AgregarEventosValidacion() {
            var ep = new ValidadorCampos(this);
            ep.AgregarCampo(boxPrecio, ValidadorCampos.TipoValidacion.NumericaNotNull);
            ep.AgregarCampo(boxFila, ValidadorCampos.TipoValidacion.NumericaNotNull);
            ep.AgregarCampo(boxAsiento, ValidadorCampos.TipoValidacion.NotNull);
        }
    }
}
