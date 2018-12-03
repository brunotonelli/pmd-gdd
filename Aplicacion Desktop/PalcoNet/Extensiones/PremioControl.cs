using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using PalcoNet.Model;
using System.IO;

namespace PalcoNet.Extensiones
{
    public partial class PremioControl : UserControl
    {
        public event EventHandler BotonClick;
        public Premio Premio;

        public PremioControl() {
            InitializeComponent();
        }

        public PremioControl(Premio premio) {
            InitializeComponent();
            Premio = premio;
            botonNombre.Text = premio.Premio_Nombre;
            labelPuntos.Text = premio.Premio_Puntos_Necesarios.ToString();
            var archivo = (Image)Properties.Resources.ResourceManager.GetObject(premio.Premio_Imagen);
            boxImagen.Image = archivo;
        }

        [Description("Imagen del premio"), Category("Apariencia")]
        public Image Imagen {
            get { return boxImagen.Image; }
            set { boxImagen.Image = value; }
        }

        [Description("Nombre del premio"), Category("Apariencia")]
        public string Nombre {
            get { return botonNombre.Text; }
            set { botonNombre.Text = value; }
        }

        [Description("Cantidad de puntos necesarios"), Category("Apariencia")]
        public string Puntos {
            get { return labelPuntos.Text; }
            set { labelPuntos.Text = value; }
        }

        private void botonNombre_Click(object sender, EventArgs e) {
            if (BotonClick != null)
                BotonClick(new PremioEventoModel { Premio = Premio, Imagen = boxImagen.Image }, e);
        }
    }
}
