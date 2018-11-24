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
    public partial class ModificacionGradoForm : Form
    {
        private int id;
        private Grado_Publicacion Seleccionado;
        public ModificacionGradoForm(Grado_Publicacion grado)
        {
            InitializeComponent();
            Seleccionado = grado;
            id = grado.Grado_ID;
            BindearCampos();
            boxNombre.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxComision.TextChangeEvent += new EventHandler(ValidarRequeridos);
        }

        private void BindearCampos()
        {
            boxNombre.Bindear(Seleccionado, "Grado_Nombre");
            boxComision.Bindear(Seleccionado,"Grado_Comision");
        }


        private void ModificacionGradoForm_Load(object sender, EventArgs e){}

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new GD2C2018Entities())
            {
                var grado = context.Grado_Publicacion.Single(c => c.Grado_ID == id);
                context.Entry(grado).CurrentValues.SetValues(Seleccionado);
                context.SaveChanges();
            }
            this.Close();
        }
        private void ValidarRequeridos(object sender, EventArgs e)
        {
            bool ok = boxNombre.Text.Length != 0 && boxComision.Text.Length != 0;
            botonGuardar.Enabled = ok;
        }
    }
}
