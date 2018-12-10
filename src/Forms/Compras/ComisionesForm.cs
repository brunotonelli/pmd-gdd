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
    public partial class ComisionesForm : Form
    {
        public ComisionesForm() {
            InitializeComponent();
            compraModelBindingSource.DataSource = GetCompras();
        }

        private List<CompraModel> GetCompras() { //no facturadas
            using (var context = new GD2C2018Entities())
            {
                var q = from c in context.Compra
                        join pub in context.Publicacion on c.Compra_Publicacion equals pub.Publicacion_ID
                        join emp in context.Espec_Empresa on pub.Publicacion_Empresa equals emp.Espec_Empresa_Cuit
                        join esp in context.Espectaculo on pub.Publicacion_Espectaculo equals esp.Espectaculo_Cod
                        where c.Compra_Facturada == false
                        select new CompraModel
                        {
                            ID = c.Compra_ID,
                            Fecha = c.Compra_Fecha,
                            Total = c.Compra_Total,
                            Empresa = emp.Espec_Empresa_Razon_Social,
                            Espectaculo = esp.Espectaculo_Descripcion,
                            Cantidad = c.Compra_Cantidad,
                            PublicacionID = c.Compra_Publicacion
                        };
                return q.OrderBy(c => c.Fecha).ToList();
            }
        }

        private void botonGenerar_Click(object sender, EventArgs e) {
            var filas = dataGrid.SelectedRows;
            using (var context = new GD2C2018Entities())
            {
                foreach (DataGridViewRow row in filas)
                {
                    var compra = row.DataBoundItem as CompraModel;
                    var factura = GetFactura(compra.PublicacionID, context);
                    var compraReal = GetCompra(compra.ID, context);

                    Item_Factura item = new Item_Factura
                    {
                        Item_Factura_Cantidad = compra.Cantidad,
                        Item_Factura_Compra = compra.ID,
                        Item_Factura_Descripcion = "Comision por compra",
                        Item_Factura_Factura = factura.Factura_Nro,
                        Item_Factura_Monto = compra.Total
                    };

                    context.Entry(item).State = System.Data.Entity.EntityState.Added;
                    compraReal.Compra_Facturada = true;
                    factura.Factura_Total += compra.Total;
                    context.Entry(compraReal).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(factura).State = System.Data.Entity.EntityState.Modified;
                    compraModelBindingSource.Remove(compra);
                }
                context.SaveChanges();
                MessageBox.Show("Puede verlas con el botón 'Ver Facturas'", "Facturas generadas", MessageBoxButtons.OK);
            }
        }

        private Factura GetFactura(decimal publicacion, GD2C2018Entities context) {
            var factura = (from fac in context.Factura
                           where fac.Factura_Publicacion == publicacion
                           select fac).FirstOrDefault();
            if (factura == null)
            {
                factura = new Factura
                {
                    Factura_Fecha = Configuracion.FechaActual,
                    Factura_Publicacion = publicacion,
                    Factura_Total = 0.0m
                };
                context.Entry(factura).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            return factura;
        }

        private Compra GetCompra(decimal compra, GD2C2018Entities context) {
            return (from c in context.Compra
                    where c.Compra_ID == compra
                    select c).FirstOrDefault();
        }

        private void botonVerFacturas_Click(object sender, EventArgs e) {
            new FacturasForm().Show();
        }

        private void ComisionesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuForm.ObtenerInstancia().Show();
        }
    }
}
