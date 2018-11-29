using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Model;

using System.Data.SqlClient;

using System.Data.Objects;
using System.Data.Entity;

namespace PalcoNet.Forms
{
    public partial class EstadisticasForm : Form
    {
        public EstadisticasForm()
        {
            InitializeComponent();
            lbl_Respuesta.Text = "";
            cb_Trimestre.SelectedIndex = 0;
            tm_Verificar.Start();
            //btn_Buscar.Enabled = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int ano;
            bool verificarCadena = int.TryParse(txt_Ano.Text,out ano);
            int tri2 = (cb_Trimestre.SelectedIndex + 1) * 3;
            int tri1 = cb_Trimestre.SelectedIndex * 3;
            if (!verificarCadena)
            {
                lbl_Respuesta.Text = "El valor ingresado en el ano es incorrecto";
            }
            else
            {
                lbl_Respuesta.Text = "";

                var context = new GD2C2018Entities();
                if (rb_ComprasCliente.Checked == true)
                {

                    /* var resultado2 = context.Database.SqlQuery
                              <IEnumerable<ComprasEstadistico>>(
                              "SELECT TOP 5 Cli_Tipo_Doc,Cli_Nro_Doc,Cli_Apellido,Cli_Nombre ,SUM(Compra_Cantidad) AS Entradas_Compradas FROM PMD.Compra JOIN PMD.Cliente ON  (Compra_Num_Doc_Cliente=Cli_Nro_Doc AND Cli_Tipo_Doc=Compra_Tipo_Doc_Cliente) "
                    + " WHERE DATEPART(QUARTER, Compra_Fecha)=" + cb_Trimestre.SelectedIndex.ToString() + " AND YEAR(Compra_Fecha)=" + ano.ToString() +
                    " GROUP BY  Cli_Tipo_Doc,Cli_Nro_Doc,Cli_Apellido,Cli_Nombre ORDER BY SUM(Compra_Cantidad) DESC;"
                              ).ToList();*/


                    /*
                         var R = from cli in context.Cliente
                                 join comp in context.Compra on cli.Cli_Nro_Doc equals comp.Compra_Num_Doc_Cliente 
                                 where comp.Compra_Fecha.Year == ano && (tri1 <= (comp.Compra_Fecha).Month && (comp.Compra_Fecha).Month <= tri2)
                                 select new {
                                     Cli_Tipo_Doc = cli.Cli_Tipo_Doc,
                                     Cli_Nro_Doc = cli.Cli_Nro_Doc,
                                     Cli_Apellido = cli.Cli_Apellido,
                                     Cli_Nombre = cli.Cli_Nombre,
                                     Entradas_Compradas = comp.Compra_Cantidad
                                 };*/

                    //comprasEstadisticoBindingSource.DataSource = resultado2;



                    // var algo1 = from cli in context.Cliente join 

                    var resultado = context.Cliente
                        .Join(context.Compra
                        .Where(w => ((DateTime)w.Compra_Fecha).Year == ano && (tri1 <= ((DateTime)w.Compra_Fecha).Month && ((DateTime)w.Compra_Fecha).Month <= tri2))
                        , cli => new { p1 = cli.Cli_Nro_Doc, p2 = cli.Cli_Tipo_Doc }, comp => new { p1 = comp.Compra_Num_Doc_Cliente, p2 = comp.Compra_Tipo_Doc_Cliente },
                        (cli, comp) => new
                        {
                            Cli_Tipo_Doc = cli.Cli_Tipo_Doc,
                            Cli_Nro_Doc = cli.Cli_Nro_Doc,
                            Cli_Apellido = cli.Cli_Apellido,
                            Cli_Nombre = cli.Cli_Nombre,
                            Entradas_Compradas = comp.Compra_Cantidad
                        }
                        ).ToList();

                    List<ComprasEstadistico> nuevoResultado = resultado.GroupBy(
                        w => new
                        {
                            w.Cli_Nro_Doc,
                            w.Cli_Tipo_Doc,
                            w.Cli_Nombre,
                            w.Cli_Apellido
                        }
                        ).Select(
                            algo => new ComprasEstadistico()
                            {
                                Cli_Nro_Doc = (int)algo.FirstOrDefault().Cli_Nro_Doc,
                                Cli_Tipo_Doc = algo.FirstOrDefault().Cli_Tipo_Doc,
                                Cli_Nombre = algo.FirstOrDefault().Cli_Nombre,
                                Cli_Apellido = algo.FirstOrDefault().Cli_Apellido,
                                Entradas_Compradas = (int)algo.Sum(x => x.Entradas_Compradas)
                            }
                            ).OrderByDescending(x => x.Entradas_Compradas)
                            .Take(5).ToList();
                    comprasEstadisticoBindingSource.DataSource = nuevoResultado;




                    /*

                            var resultado= context.Cliente
                           .Join(context.Compra, cli => new { p1 = cli.Cli_Nro_Doc, p2 = cli.Cli_Tipo_Doc }, comp => new { p1 = comp.Compra_Num_Doc_Cliente, p2 = comp.Compra_Tipo_Doc_Cliente },
                                        (cli, comp) => new
                                        {
                                            Cli_Tipo_Doc = cli.Cli_Tipo_Doc,
                                            Cli_Nro_Doc = cli.Cli_Nro_Doc,
                                            Cli_Apellido = cli.Cli_Apellido,
                                            Cli_Nombre = cli.Cli_Nombre,
                                            Entradas_Compradas = comp.Compra_Cantidad
                                        }
                                        ).ToList();

                            var nuevoResultado = resultado.GroupBy(
                                w => new
                                {
                                    w.Cli_Nro_Doc,
                                    w.Cli_Tipo_Doc,
                                    w.Cli_Nombre,
                                    w.Cli_Apellido
                                }
                                ).Select(
                                    algo => new
                                    {
                                        algo.FirstOrDefault().Cli_Nro_Doc,
                                        algo.FirstOrDefault().Cli_Tipo_Doc,
                                        algo.FirstOrDefault().Cli_Nombre,
                                        algo.FirstOrDefault().Cli_Apellido
                                    }

                                    );
                    */







                }
                if (rb_PuntosCliente.Checked == true)
                {



                }
                else//Empresas
                {
                    if (rb_Empresas.Checked == true)
                    {
                        try
                        {
                            string cadena = "SELECT e.Espec_Empresa_Cuit,e.Espec_Empresa_Razon_Social, PMD.localidadesTotales(e.Espec_Empresa_Cuit," + txt_Ano.Text + "," + cb_Trimestre.Text + ")-PMD.localidadesVendidas(e.Espec_Empresa_Cuit," + txt_Ano.Text + "," + cb_Trimestre.Text + ") AS Sobrante FROM PMD.Espec_Empresa e ORDER BY e.Espec_Empresa_Razon_Social, PMD.localidadesTotales(e.Espec_Empresa_Cuit," + txt_Ano.Text + "," + cb_Trimestre.Text + ")-PMD.localidadesVendidas(e.Espec_Empresa_Cuit," + txt_Ano.Text + "," + cb_Trimestre.Text + ") DESC";


                            var wea = context.Database
                            .SqlQuery<EmpEstadistico>("SELECT TOP 5 e.Espec_Empresa_Cuit,e.Espec_Empresa_Razon_Social, PMD.localidadesTotales(e.Espec_Empresa_Cuit," + txt_Ano.Text + "," + cb_Trimestre.Text + ")-PMD.localidadesVendidas(e.Espec_Empresa_Cuit," + txt_Ano.Text + "," + cb_Trimestre.Text + ") AS Sobrante FROM PMD.Espec_Empresa e ORDER BY 3 DESC")
                            .ToList();


                            dg_WEA.DataSource = wea;

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);

                        }

                        //DataTable retVal = new DataTable();

                        //retVal = context.ExecuteStoreQuery<DataTable>(cadena, parameters).FirstOrDefault();



                    }



                    //clienteBindingSource.DataSource=

                }
            }

        }

        private void rb_Empresas_CheckedChanged(object sender, EventArgs e)
        {
            
            rb_ComprasCliente.Checked = false;
            rb_PuntosCliente.Checked = false;
        }

        private void rb_PuntosCliente_CheckedChanged(object sender, EventArgs e)
        {
            rb_ComprasCliente.Checked = false;
            rb_Empresas.Checked = false;
        }

        private void rb_ComprasCliente_CheckedChanged(object sender, EventArgs e)
        {
            rb_Empresas.Checked = false;
            rb_PuntosCliente.Checked = false;
        }

        private void tm_Verificar_Tick(object sender, EventArgs e)
        {
            if (txt_Ano.Text == "" || (rb_ComprasCliente.Checked == false && rb_Empresas.Checked == false &&  rb_PuntosCliente.Checked == false))
            {
                btn_Buscar.Enabled = false;
            }
            else
            {
                btn_Buscar.Enabled = true;
            }

        }
    }
}
