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
    public partial class HistorialComprasForm : Form
    {
        IPagedList<HistorialModel> Historial;
        int Pagina = 1, Cant;
        HistorialModel Seleccionado;

        public HistorialComprasForm()
        {
            InitializeComponent();
        }


        public IPagedList<HistorialModel> GetHistorial(int pagina = 1, int tamaño = 20)
        {

            using (GD2C2018Entities context = new GD2C2018Entities())
            {   

                var list = (from comp in context.Compra
                            join pub in context.Publicacion on comp.Compra_Publicacion equals pub.Publicacion_ID
                            join esp in context.Espectaculo on pub.Publicacion_Espectaculo equals esp.Espectaculo_Cod
                            where comp.Compra_Num_Doc_Cliente == InfoSesion.NroDocumento
                            && comp.Compra_Tipo_Doc_Cliente == InfoSesion.TipoDocumento
                            select new HistorialModel {
                                Fecha = comp.Compra_Fecha,
                                Espectaculo = esp.Espectaculo_Descripcion,
                                Cantidad = comp.Compra_Cantidad,
                                Total = comp.Compra_Total,
                                FormaPago = comp.Compra_Forma_Pago
                            }).OrderBy(comp => comp.Fecha);

                Cant = list.Count() / tamaño + 1;
                return list.ToPagedList(pagina, tamaño);
            }
        }

        private void HistorialComprasForm_Load(object sender, EventArgs e)
        {
            Historial = GetHistorial();
            botonSiguiente.Enabled = Historial.HasNextPage;
            botonAnterior.Enabled = Historial.HasPreviousPage;
            dataGrid.DataSource = Historial.ToList();
            labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cant);
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            if (Historial.HasNextPage)
            {
                Historial = GetHistorial(++Pagina);
                botonSiguiente.Enabled = Historial.HasNextPage;
                botonAnterior.Enabled = Historial.HasPreviousPage;
                dataGrid.DataSource = Historial.ToList();
                labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cant);
            }
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            if (Historial.HasPreviousPage)
            {
                Historial = GetHistorial(--Pagina);
                botonSiguiente.Enabled = Historial.HasNextPage;
                botonAnterior.Enabled = Historial.HasPreviousPage;
                dataGrid.DataSource = Historial.ToList();
                labelPagina.Text = string.Format("Pagina {0} de {1}", Pagina, Cant);
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                Seleccionado = dataGrid.SelectedRows[0].DataBoundItem as HistorialModel;
            }
        }


    }
}
