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
using PalcoNet.Model;
using System.Configuration;
using PagedList;

namespace PalcoNet.Forms
{
    public partial class ComprarForm : Form
    {
        IPagedList<PublicacionModel> Publicaciones;
        int Pagina = 1, Cantidad;

        public ComprarForm() {
            InitializeComponent();
        }

        public async Task<IPagedList<PublicacionModel>> GetPublicacionesAsync(int pagina = 1, int tamaño = 20) {
            return await Task.Factory.StartNew(()=>
            {
                using (GD2C2018Entities context = new GD2C2018Entities())
                {
                    Cantidad = context.Publicacion.Count() / 20;
                    return (from p in context.Publicacion
                                 join esp in context.Espectaculo on p.Publicacion_Espectaculo equals esp.Espectaculo_Cod
                                 join emp in context.Espec_Empresa on p.Publicacion_Empresa equals emp.Espec_Empresa_Cuit
                                 select new PublicacionModel
                                 {
                                     ID = p.Publicacion_ID,
                                     Nombre = esp.Espectaculo_Descripcion,
                                     Rubro = esp.Rubro.Rubro_Descripcion,
                                     FechaInicial = esp.Espectaculo_Fecha ?? Properties.Settings.Default.FechaActual,
                                     FechaFinal = esp.Espectaculo_Fecha_Venc ?? Properties.Settings.Default.FechaActual,
                                     FechaPublicacion = p.Publicacion_Fecha ?? Properties.Settings.Default.FechaActual,
                                     Empresa = emp.Espec_Empresa_Razon_Social
                                 }).OrderBy(p => p.ID).ToPagedList(pagina, tamaño);
                }
            });
        }

        private async void ComprarForm_Load(object sender, EventArgs e) {
            Publicaciones = await GetPublicacionesAsync();
            botonSiguiente.Enabled = Publicaciones.HasNextPage;
            botonAnterior.Enabled = Publicaciones.HasPreviousPage;
            dataGrid.DataSource = Publicaciones.ToList();
            labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cantidad);
        }

        private async void botonSiguiente_Click(object sender, EventArgs e) {
            if (Publicaciones.HasNextPage)
            {
                Publicaciones = await GetPublicacionesAsync(++Pagina);
                botonSiguiente.Enabled = Publicaciones.HasNextPage;
                botonAnterior.Enabled = Publicaciones.HasPreviousPage;
                dataGrid.DataSource = Publicaciones.ToList();
                labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cantidad);
            }
        }

        private async void botonAnterior_Click(object sender, EventArgs e) {
            if (Publicaciones.HasPreviousPage)
            {
                Publicaciones = await GetPublicacionesAsync(--Pagina);
                botonSiguiente.Enabled = Publicaciones.HasNextPage;
                botonAnterior.Enabled = Publicaciones.HasPreviousPage;
                dataGrid.DataSource = Publicaciones.ToList();
                labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cantidad);
            }
        }
    }
}
