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
    public partial class EditarPublicacionesSeleccionForm : Form
    {
        GD2C2018Entities context = new GD2C2018Entities();
        List<PublicacionModel> Publicaciones;
        bool MostrarTodas = false;

        public EditarPublicacionesSeleccionForm() {
            InitializeComponent();
            MostrarTodas = Sesion.Rol.Rol_ID == "ADM" || Sesion.Rol.Rol_ID == "GOD";
            CargarPublicaciones();
            labelViendo.Text = MostrarTodas ?
                "Mostrando todas las publicaciones como administrador" :
                "Mostrando sus publicaciones";
        }

        private void CargarPublicaciones() {
            var query = from p in context.Publicacion
                        where p.Publicacion_Estado == 1 //borrador
                        join e in context.Espectaculo on p.Publicacion_Espectaculo equals e.Espectaculo_Cod
                        select new PublicacionModel
                        {
                            ID = p.Publicacion_ID,
                            FechaEspectaculo = p.Publicacion_Fecha_Espectaculo,
                            FechaPublicacion = p.Publicacion_Fecha,
                            Nombre = e.Espectaculo_Descripcion
                        };
            if (MostrarTodas)
                Publicaciones = query.ToList();
            else //soy una empresa
            {
                var cuit = Sesion.Empresa.Espec_Empresa_Cuit;
                Publicaciones = query.Where(p => p.Empresa == cuit).ToList();
            }
            publicacionModelBindingSource.DataSource =
                Publicaciones.OrderByDescending(p => p.FechaPublicacion);
        }

        private void botonEditar_Click(object sender, EventArgs e) {
            var row = dataGrid.SelectedRows[0];
            var pub = row.DataBoundItem as PublicacionModel;
            Publicacion real = context.Publicacion.Single(p => p.Publicacion_ID == pub.ID);
            new EditarPublicacionForm(real).Show(this);
            this.Hide();
        }

        private void EditarPublicacionesSeleccionForm_FormClosed(object sender, FormClosedEventArgs e) {
            MenuForm.ObtenerInstancia().Show();
        }
    }
}
