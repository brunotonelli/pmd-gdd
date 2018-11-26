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
    public partial class FacturasForm : Form
    {
        public FacturasForm() {
            InitializeComponent();
            facturaBindingSource.DataSource = GetFacturas();
        }

        private List<Factura> GetFacturas() {
            var context = new GD2C2018Entities();
            return context.Factura.OrderBy(f => f.Factura_Fecha).ToList();
        }

        private void botonDetalles_Click(object sender, EventArgs e) {
            Factura factura = dataGrid.SelectedRows[0].DataBoundItem as Factura;
            new FacturaDetallesForm(factura).Show();
        }
    }
}
