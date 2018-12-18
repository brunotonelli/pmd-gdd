using PalcoNet.Extensiones;
using PalcoNet.Model;
using PalcoNet.Validaciones;
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
        GD2C2018Entities context = new GD2C2018Entities();

        List<Ubicacion> Ubicaciones = new List<Ubicacion>();
        List<FechaHoraModel> Fechas = new List<FechaHoraModel>();

        bool GradoCambiado = false;

        public GenerarPublicacionForm() {
            InitializeComponent();
            boxHora.Format = DateTimePickerFormat.Time;
            boxHora.ShowUpDown = true;
            CargarComboBox();
            AgregarEventosValidacion();
            boxEmpresa.Text = Sesion.Empresa.Espec_Empresa_Razon_Social;
            boxFecha.MinDate = Configuracion.FechaActual;
            boxFechaPublicacion.MinDate = Configuracion.FechaActual;
        }
        
        private void botonAgregarFecha_Click(object sender, EventArgs e) {
            var item = new FechaHoraModel();
            var f = boxFecha.Value;
            var h = boxHora.Value;
            item.Fecha = f.ToLongDateString();
            item.Hora = h.ToShortTimeString();
            item.Valor = new DateTime(f.Year, f.Month, f.Day, h.Hour, h.Minute, h.Second);
            if (FechaValida(item.Valor))
            {
                fechaHoraModelBindingSource.Add(item);
                Fechas.Add(item);
                int i = gridFechasHoras.Rows.GetLastRow(DataGridViewElementStates.None);
                gridFechasHoras.Rows[i].Cells["botonBorrar"].Value = "X";
            }
            else
            {
                MessageBox.Show("La fecha no puede ser anterior a la fecha de la publicación " +
                    "ni se pueden repetir fechas iguales");
            }
        }

        private void gridFechasHoras_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                fechaHoraModelBindingSource.RemoveAt(e.RowIndex);
                Fechas.RemoveAt(e.RowIndex);
            }
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

        private bool FechaValida(DateTime fecha) {
            return fecha >= boxFechaPublicacion.Value && Fechas.All(f => f.Valor != fecha);
        }

        private void gridUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                ubicacionBindingSource.RemoveAt(e.RowIndex);
                Ubicaciones.RemoveAt(e.RowIndex);
            }
        }

        private void CargarComboBox() {
            boxEstado.SelectedItem = "Borrador";
            foreach (var rubro in context.Rubro)
                boxRubro.Items.Add(rubro.Rubro_Descripcion);
            foreach (var grado in context.Grado_Publicacion)
                boxGrado.Items.Add(grado.Grado_Nombre);
            boxRubro.SelectedIndex = 0;
            boxGrado.SelectedIndex = 0;
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
            ep.AgregarCampo(boxFila, ValidadorCampos.TipoValidacion.NotNull);
            ep.AgregarCampo(boxAsiento, ValidadorCampos.TipoValidacion.NumericaNotNull);
        }

        #region LOGICA DE ALTA

        private void botonGenerar_Click(object sender, EventArgs e) {
            bool hayUbicaciones = Ubicaciones.Count() > 0;
            bool hayFechas = Fechas.Count() > 0;

            if (!hayUbicaciones)
                MessageBox.Show("No se ingresaron ubicaciones", "Error");
            if (!hayFechas)
                MessageBox.Show("No se ingresaron fechas", "Error");

            if (hayFechas && hayUbicaciones)
            {
                Espectaculo espectaculo = GenerarEspectaculo();
                List<Publicacion> publicaciones = GenerarPublicaciones(espectaculo);
                CargarUbicaciones(publicaciones);
                string mensaje = string.Format("{0} publicaciones con {1} ubicaciones generadas con éxito!", Fechas.Count(), Ubicaciones.Count());
                MessageBox.Show(mensaje, "Error");
                this.Close();
            }
        }

        private Espectaculo GenerarEspectaculo() {
            var rubro = context.Rubro.Single(r => r.Rubro_Descripcion == boxRubro.Text);
            var espectaculo =  new Espectaculo
            {
                Espectaculo_Descripcion = boxDescripcion.Text,
                Espectaculo_Direccion = boxDireccion.Text,
                Espectaculo_Rubro = rubro.Rubro_ID
            };
            context.Entry(espectaculo).State = System.Data.Entity.EntityState.Added;
            context.SaveChanges();
            return espectaculo;
        }

        private List<Publicacion> GenerarPublicaciones(Espectaculo espectaculo) {
            var lista = new List<Publicacion>();
            var estado = context.Estado.Single(e => e.Estado_Descripcion == boxEstado.Text);
            var grado = context.Grado_Publicacion.Single(g => g.Grado_Nombre == boxGrado.Text);
            foreach (var fecha in Fechas)
            {
                var publicacion = new Publicacion
                {
                    Publicacion_Espectaculo = espectaculo.Espectaculo_Cod,
                    Publicacion_Estado = estado.Estado_ID,
                    Publicacion_Fecha = boxFechaPublicacion.Value,
                    Publicacion_Fecha_Espectaculo = fecha.Valor,
                    Publicacion_Grado = grado.Grado_ID,
                    Publicacion_Localidades = Ubicaciones.Count(),
                    Publicacion_Empresa = Sesion.Empresa.Espec_Empresa_Cuit
                };
                context.Entry(publicacion).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                lista.Add(publicacion);                
            }            
            return lista;
        }

        private void CargarUbicaciones(List<Publicacion> publicaciones) {
            foreach(var publicacion in publicaciones)
            {
                foreach(var ubicacion in Ubicaciones)
                {
                    var u = ubicacion.ConPublicacion(publicacion.Publicacion_ID);
                    context.Entry(u).State = System.Data.Entity.EntityState.Added;
                    context.SaveChanges();
                }
            }
        }


        #endregion

        private void GenerarPublicacionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }

    }
}
