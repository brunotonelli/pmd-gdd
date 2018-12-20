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
    public partial class FacturaDetallesForm : Form
    {
        Factura Factura;
        public FacturaDetallesForm(Factura factura) {
            InitializeComponent();
            Factura = factura;
            CargarDatos();
            this.MouseDown += new MouseEventHandler(DragForm);
        }

        private void CargarDatos() {
            var context = new GD2C2018Entities();
            var query = from p in context.Publicacion
                        join e in context.Espec_Empresa on p.Publicacion_Empresa equals e.Espec_Empresa_Cuit
                        where p.Publicacion_ID == Factura.Factura_Publicacion
                        select new
                        {
                            p.Publicacion_ID,
                            e.Espec_Empresa_Razon_Social,
                            e.Espec_Empresa_Cuit,
                            e.Espec_Empresa_Dom_Calle,
                            e.Espec_Empresa_Nro_Calle,
                            e.Espec_Empresa_Telefono
                        };
            var datos = query.Single();
            labelCUIT.Text = datos.Espec_Empresa_Cuit;
            labelEmpresa.Text = datos.Espec_Empresa_Razon_Social;
            labelDireccion.Text = datos.Espec_Empresa_Dom_Calle + " " + datos.Espec_Empresa_Nro_Calle;
            labelNumero.Text = "#" + Factura.Factura_Nro;
            labelTelefono.Text = datos.Espec_Empresa_Telefono;
            labelFecha.Text = Factura.Factura_Fecha.Value.ToShortDateString();
            var items = GetItems();
            itemModelBindingSource.DataSource = items;
            labelTotal.Text = "$ " + Factura.Factura_Total;
        }

        private List<ItemModel> GetItems() {
            using (var context = new GD2C2018Entities())
            {
                var comisiones = from i in context.Item_Factura
                                 where i.Item_Factura_Factura == Factura.Factura_Nro
                                 select new ItemModel
                                 {
                                     Descripcion = i.Item_Factura_Descripcion,
                                     MontoCompra = i.Compra.Compra_Total,
                                     PrecioString = "- " + i.Item_Factura_Monto,
                                     Precio = i.Item_Factura_Monto
                                 };
                return comisiones.ToList();
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e) {
           dataGrid.ClearSelection();
        }

        private void botonSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
