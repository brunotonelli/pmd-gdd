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
            var items = GetItems();
            itemModelBindingSource.DataSource = items;
            labelTotal.Text = "$ " + items.Sum(i => i.Precio).ToString();
        }

        private List<ItemModel> GetItems() {
            using (var context = new GD2C2018Entities())
            {
                var comisiones = from i in context.Item_Factura
                                 where i.Item_Factura_Factura == Factura.Factura_Nro
                                 select new ItemModel
                                 {
                                     Concepto = i.Item_Factura_Descripcion,
                                     PrecioString = "- $ " + i.Item_Factura_Monto,
                                     Precio = i.Item_Factura_Monto * -1
                                 };
                var ventas = from c in context.Compra
                             where c.Compra_Publicacion == Factura.Factura_Publicacion
                             select new ItemModel
                             {
                                 Concepto = "Venta de " + c.Compra_Cantidad + " ubicaciones",
                                 PrecioString = "$ " + c.Compra_Total,
                                 Precio = c.Compra_Total                                 
                             };
                return comisiones.Union(ventas).ToList();
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e) {
           dataGrid.ClearSelection();
        }
    }
}
