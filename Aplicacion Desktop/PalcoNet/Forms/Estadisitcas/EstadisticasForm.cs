using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PalcoNet.Model;
using System.Data.Entity;
using PalcoNet.Extensiones;
using System.Data.Entity.SqlServer;

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
            int año = int.Parse(txt_Ano.Text), trimestre = int.Parse(cb_Trimestre.Text);
            bool verificarCadena = int.TryParse(txt_Ano.Text, out año);
            if (!verificarCadena)
            {
                lbl_Respuesta.Text = "El valor ingresado en el ano es incorrecto";
            }
            else
            {
                lbl_Respuesta.Text = "";

                var context = new GD2C2018Entities();
                if (rb_ComprasCliente.Checked == true)//ORDENADO MES ANO
                {
                    var query = from cli in context.Cliente
                                join com in context.Compra on new { t = cli.Cli_Tipo_Doc, n = cli.Cli_Nro_Doc } equals new { t = com.Compra_Tipo_Doc_Cliente, n = com.Compra_Num_Doc_Cliente }
                                where com.Compra_Fecha.Year == año && 
                                SqlFunctions.DatePart("QUARTER", com.Compra_Fecha) == trimestre
                                group new { cli.Cli_Tipo_Doc, cli.Cli_Nro_Doc, cli.Cli_Nombre, cli.Cli_Apellido, com.Compra_Cantidad } by new { cli.Cli_Tipo_Doc, cli.Cli_Nro_Doc, cli.Cli_Nombre, cli.Cli_Apellido }
                                into c
                                select new
                                {
                                    c.Key.Cli_Tipo_Doc,
                                    c.Key.Cli_Nro_Doc,
                                    c.Key.Cli_Nombre,
                                    c.Key.Cli_Apellido,
                                    Entradas_Compradas = c.Sum(x => x.Compra_Cantidad)
                                };

                    comprasEstadisticoBindingSource.DataSource = query
                        .OrderByDescending(c => c.Entradas_Compradas)
                        .Take(5)
                        .ToList();
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
                            var query = (from emp in context.Espec_Empresa
                                         select new
                                         {
                                             emp.Espec_Empresa_Cuit,
                                             emp.Espec_Empresa_Razon_Social,
                                             Sobrante = FuncionesSQL.LocalidadesTotales(emp.Espec_Empresa_Cuit, año, trimestre) -
                                                        FuncionesSQL.LocalidadesVendidas(emp.Espec_Empresa_Cuit, año, trimestre)
                                         })
                                         .OrderByDescending(emp => emp.Sobrante).Take(5); //falta filtrar por grado ?
                                      
                            var list = query.ToList();

                            dg_WEA.DataSource = list;
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);

                        }
                    }
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
