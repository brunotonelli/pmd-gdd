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
    public partial class AltaGrado : Form
    {
        DataGridView DataGrid;
        private Grado_Publicacion Nuevo = new Grado_Publicacion();
        public AltaGrado(DataGridView dataGrid)
        {
            InitializeComponent();
            DataGrid = dataGrid;
            
            BindearCampos();
            boxNombre.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxComision.TextChangeEvent += new EventHandler(ValidarRequeridos);
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new GD2C2018Entities() )
            {
                Nuevo.Grado_Habilitado = true;
                context.Entry(Nuevo).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                DataGrid.DataSource = context.Grado_Publicacion.ToList();
            }
            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindearCampos()
        {
            boxNombre.Bindear(Nuevo, "Grado_Nombre");
            boxComision.Bindear(Nuevo, "Grado_Comision");
        }

        private void ValidarRequeridos(object sender, EventArgs e)
        {
            bool ok = boxNombre.Text.Length != 0 && boxComision.Text.Length != 0;
            botonGuardar.Enabled = ok;
        }

    }
}
