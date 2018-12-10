using PalcoNet.Validaciones;
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
    public partial class AsociarTarjeta : Form
    {
        public AsociarTarjeta()
        {
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e) {
            string numero = boxNumero.Text;
            string tipo = boxTipoTarjeta.Text;
            string dniTipo = Sesion.Cliente.Cli_Tipo_Doc;
            decimal dniNum = Sesion.Cliente.Cli_Nro_Doc;

            using (var context = new GD2C2018Entities())
            {
                var cli = context.Cliente
                    .Single(c => c.Cli_Nro_Doc == dniNum && c.Cli_Tipo_Doc == dniTipo);

                cli.Cli_Tarjeta_Num = numero;
                cli.Cli_Tarjeta_Tipo = tipo;
                context.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

            this.Close();
        }

        private void AgregarEventosValidacion() {
            var ep = new ValidadorCampos(this);
            ep.AgregarCampo(boxNumero, ValidadorCampos.TipoValidacion.Numerica);
        }
    }
}
