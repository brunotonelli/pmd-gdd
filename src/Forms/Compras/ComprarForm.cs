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
        PublicacionModel Seleccionado;
        bool usarFechas = false, usarFiltros = false;

        public ComprarForm() {
            InitializeComponent();
            InicializarFiltros();
        }

        public IPagedList<PublicacionModel> GetPublicaciones(int pagina = 1, int tamaño = 20) {

            using (GD2C2018Entities context = new GD2C2018Entities())
            {
                var list = (from p in context.Publicacion
                            join esp in context.Espectaculo on p.Publicacion_Espectaculo equals esp.Espectaculo_Cod
                            join emp in context.Espec_Empresa on p.Publicacion_Empresa equals emp.Espec_Empresa_Cuit
                            where p.Publicacion_Estado == 2
                            && p.Publicacion_Fecha >= Configuracion.FechaActual
                            && p.Publicacion_Fecha_Espectaculo >= Configuracion.FechaActual
                            select new PublicacionModel
                            {
                                ID = p.Publicacion_ID,
                                Nombre = esp.Espectaculo_Descripcion,
                                Rubro = esp.Rubro.Rubro_Descripcion,
                                FechaEspectaculo = p.Publicacion_Fecha_Espectaculo,
                                FechaPublicacion = p.Publicacion_Fecha,
                                Empresa = emp.Espec_Empresa_Razon_Social,
                                Localidades = p.Publicacion_Localidades ?? 0
                            })
                 .OrderBy(p => p.ID);
                if (!usarFiltros)
                {
                    Cantidad = list.Count() / tamaño + 1;
                    return list.ToPagedList(pagina, tamaño);
                }
                else
                {
                    var rubrosFiltro = listBoxRubros.CheckedItems.Cast<string>().ToList();
                    var ret = list
                       .Where(p => (p.Nombre.Contains(boxDescripcion.Text)
                        && ((p.FechaPublicacion < boxFechaFinal.Value && boxFechaInicial.Value < p.FechaEspectaculo) || !usarFechas)
                        && rubrosFiltro.Contains(p.Rubro)) || !usarFiltros);
                    Cantidad = ret.Count() / tamaño + 1;
                    return ret.ToPagedList(pagina, tamaño);
                }
            }
        }

        private void ComprarForm_Load(object sender, EventArgs e) {
            Publicaciones = GetPublicaciones();
            botonSiguiente.Enabled = Publicaciones.HasNextPage;
            botonAnterior.Enabled = Publicaciones.HasPreviousPage;
            dataGrid.DataSource = Publicaciones.ToList();
            labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cantidad);
        }

        private void botonSiguiente_Click(object sender, EventArgs e) {
            if (Publicaciones.HasNextPage)
            {
                Publicaciones = GetPublicaciones(++Pagina);
                botonSiguiente.Enabled = Publicaciones.HasNextPage;
                botonAnterior.Enabled = Publicaciones.HasPreviousPage;
                dataGrid.DataSource = Publicaciones.ToList();
                labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cantidad);
            }
        }

        private void botonAnterior_Click(object sender, EventArgs e) {
            if (Publicaciones.HasPreviousPage)
            {
                Publicaciones = GetPublicaciones(--Pagina);
                botonSiguiente.Enabled = Publicaciones.HasNextPage;
                botonAnterior.Enabled = Publicaciones.HasPreviousPage;
                dataGrid.DataSource = Publicaciones.ToList();
                labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cantidad);
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e) {
            usarFiltros = false;
            boxDescripcion.Text = string.Empty;
            listBoxRubros.ClearSelected();
            boxFechaInicial.Value = Configuracion.FechaActual;
            boxFechaFinal.Value = Configuracion.FechaActual;

            Publicaciones = GetPublicaciones();
            botonSiguiente.Enabled = Publicaciones.HasNextPage;
            botonAnterior.Enabled = Publicaciones.HasPreviousPage;
            dataGrid.DataSource = Publicaciones.ToList();
            labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cantidad);
        }

        private void botonBuscar_Click(object sender, EventArgs e) {
            usarFiltros = true;
            Publicaciones = GetPublicaciones();
            botonSiguiente.Enabled = Publicaciones.HasNextPage;
            botonAnterior.Enabled = Publicaciones.HasPreviousPage;
            dataGrid.DataSource = Publicaciones.ToList();
            labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cantidad);
        }

        private void checkFecha_CheckedChanged(object sender, EventArgs e) {
            boxFechaInicial.Enabled = checkFecha.Checked;
            boxFechaFinal.Enabled = checkFecha.Checked;
            usarFechas = checkFecha.Checked;
        }

        private void botonComprar_Click(object sender, EventArgs e) {
            new ConfirmarCompraForm(Seleccionado).Show();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e) {
            if (dataGrid.SelectedRows.Count > 0)
            {
                Seleccionado = dataGrid.SelectedRows[0].DataBoundItem as PublicacionModel;
                botonComprar.Enabled = true;
            }
        }

        private void InicializarFiltros() {
            boxFechaInicial.MinDate = Configuracion.FechaActual;
            boxFechaFinal.MinDate = Configuracion.FechaActual;
            boxFechaInicial.Value = Configuracion.FechaActual;
            boxFechaFinal.Value = Configuracion.FechaActual;
            listBoxRubros.Items.Clear();
            using (var c = new GD2C2018Entities())
            {
                List<string> rubros = c.Rubro.Select(r => r.Rubro_Descripcion).ToList();
                int i = 0;
                foreach (var r in rubros)
                {
                    listBoxRubros.Items.Add(r);
                    listBoxRubros.SetItemChecked(i, true);
                    i++;
                }
            }
        }

        private void ComprarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }

    }
}
