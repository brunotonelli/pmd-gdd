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
            dg_WEA.Visible = false;
            txt_Ano.TabIndex = 1;
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
                dg_WEA.Visible = true;
                lbl_Respuesta.Text = "";
                var context = new GD2C2018Entities();
                if (rb_ComprasCliente.Checked == true)//ORDENADO MES ANO
                {

                    string qwery="SELECT TOP 5 (SELECT e.Espec_Empresa_Razon_Social From PMD.Espec_Empresa e WHERE e.Espec_Empresa_Cuit=pl.Publicacion_Empresa)AS Empresa,pl.Publicacion_ID,cm.Compra_Tipo_Doc_Cliente,cm.Compra_Num_Doc_Cliente,SUM(cm.Compra_Cantidad) AS Cantidad FROM PMD.Publicacion pl JOIN PMD.Compra cm ON (pl.Publicacion_ID=cm.Compra_Publicacion) WHERE  YEAR(pl.Publicacion_Fecha)= "+  txt_Ano.Text    +" AND	MONTH(pl.Publicacion_Fecha)>  "+   ((cb_Trimestre.SelectedIndex)*3).ToString() +"   AND  MONTH(pl.Publicacion_Fecha)<="+    ((cb_Trimestre.SelectedIndex+1)*3).ToString()  + " GROUP BY pl.Publicacion_ID,cm.Compra_Tipo_Doc_Cliente,cm.Compra_Num_Doc_Cliente,pl.Publicacion_Empresa ORDER BY 5 DESC";
                    var wea = context.Database
                            .SqlQuery<ComprasEstadistico>(qwery)
                            .ToList();
                    dg_WEA.DataSource = wea;
                    
                }
                if (rb_PuntosCliente.Checked == true)
                {
                    var query = from pun in context.Puntos
                                join cli in context.Cliente on
                                new { t = pun.Puntos_Tipo_Doc_Cliente, n = pun.Puntos_Num_Doc_Cliente }
                                equals new { t = cli.Cli_Tipo_Doc, n = cli.Cli_Nro_Doc }
                                where pun.Puntos_Vencimiento.Year < año ||
                                      pun.Puntos_Vencimiento.Year == año &&
                                      SqlFunctions.DatePart("QUARTER", pun.Puntos_Vencimiento) <= trimestre
                                group new { pun.Puntos_Cantidad } by new { cli.Cli_Tipo_Doc, cli.Cli_Nro_Doc, cli.Cli_Nombre, cli.Cli_Apellido }
                                into reg
                                select new
                                {
                                    Nombre = reg.Key.Cli_Nombre,
                                    Apellido = reg.Key.Cli_Apellido,
                                    Puntos = reg.Sum(x => x.Puntos_Cantidad)
                                };

                    dg_WEA.DataSource = query.OrderByDescending(x => x.Puntos).Take(5).ToList();
                }
                else//Empresas
                {
                    if (rb_Empresas.Checked == true)
                    {
                        string qwery = "SELECT TOP 5 e.Espec_Empresa_Cuit,e.Espec_Empresa_Razon_Social,p.Publicacion_ID,(p.Publicacion_Localidades - SUM(c.Compra_Cantidad)) AS Cantidad  FROM PMD.Espec_Empresa e JOIN PMD.Publicacion p ON (p.Publicacion_Empresa=e.Espec_Empresa_Cuit) JOIN PMD.Compra c ON (c.Compra_Publicacion=p.Publicacion_ID) WHERE YEAR(p.Publicacion_Fecha)= " + txt_Ano.Text + " AND p.Publicacion_Estado=3	AND	MONTH(p.Publicacion_Fecha)>  " + ((cb_Trimestre.SelectedIndex) * 3).ToString() + " AND  MONTH(p.Publicacion_Fecha)<=" + ((cb_Trimestre.SelectedIndex + 1) * 3).ToString() + " GROUP BY e.Espec_Empresa_Cuit,e.Espec_Empresa_Razon_Social,p.Publicacion_ID,p.Publicacion_Localidades,p.Publicacion_Fecha_Espectaculo,p.Publicacion_Grado ORDER BY 4 DESC,p.Publicacion_Fecha_Espectaculo ASC,p.Publicacion_Grado ASC ";
                        var wea = context.Database
                            .SqlQuery<EmpEstadistico>(qwery)
                            .ToList();
                        dg_WEA.DataSource = wea;
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
