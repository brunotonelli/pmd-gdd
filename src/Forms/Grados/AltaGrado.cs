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
    public partial class AltaGrado : Form
    {
        DataGridView DataGrid;
        private Grado_Publicacion Nuevo = new Grado_Publicacion();
        public AltaGrado(DataGridView dataGrid)
        {
            InitializeComponent();
            DataGrid = dataGrid;
            AgregarEventosValidacion();

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            BindearDatos();
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

        private void BindearDatos()
        {
            Nuevo.Grado_Nombre = boxNombre.Text;
            Nuevo.Grado_Comision = decimal.Parse(boxComision.Text);
            Nuevo.Grado_Habilitado = true;
        }

        private void ValidarRequeridos(object sender, EventArgs e)
        {
            bool ok = boxNombre.Text.Length != 0 && boxComision.Text.Length != 0;
            botonGuardar.Enabled = ok;
        }

        private void AgregarEventosValidacion() {
            var ep = new ValidadorCampos(this);
            ep.AgregarCampo(boxComision, ValidadorCampos.TipoValidacion.Numerica);
            boxNombre.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxComision.TextChangeEvent += new EventHandler(ValidarRequeridos);
        }

    }
}
