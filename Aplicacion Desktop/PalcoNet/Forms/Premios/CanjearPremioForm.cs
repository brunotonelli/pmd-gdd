using PalcoNet.Extensiones;
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
    public partial class CanjearPremioForm : Form
    {
        Premio P;
        int Puntos;
        PuntosForm FormPadre;

        public CanjearPremioForm(PuntosForm padre, Premio premio, Image imagen, int puntos) {
            InitializeComponent();
            FormPadre = padre;
            P = premio;
            Puntos = puntos;
            textDescripcion.Text = premio.Premio_Descripcion;
            labelNombre.Text = premio.Premio_Nombre;
            labelPuntos.Text = premio.Premio_Puntos_Necesarios.ToString();
            boxImagen.Image = imagen;
        }


        private void botonCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void botonCanjear_Click(object sender, EventArgs e) {
            if (Puntos < P.Premio_Puntos_Necesarios)
                MessageBox.Show("No tiene los puntos necesarios para este premio.", "Error", MessageBoxButtons.OK);
            else
            {
                string mensaje = string.Format("Está seguro que desea canjear {0} puntos por {1}?", P.Premio_Puntos_Necesarios, P.Premio_Nombre);
                DialogResult dr = MessageBox.Show(mensaje, "Confirmar canje", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    FormPadre.ConfirmarCanje(P);
            }
            this.Close();
        }
    }
}
