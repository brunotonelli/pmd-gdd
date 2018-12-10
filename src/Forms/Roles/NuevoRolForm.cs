using PalcoNet.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Forms
{
    public partial class NuevoRolForm : Form
    {
        DataGridView DataGrid;

        public NuevoRolForm(DataGridView dataGrid) {
            InitializeComponent();
            DataGrid = dataGrid;
            AgregarEventosValidacion();
        }

        private void botonCrear_Click(object sender, EventArgs e) {

            Rol rol = new Rol();
            rol.Rol_ID = boxCodigo.Text;
            rol.Rol_Nombre = boxNombre.Text;
            rol.Rol_Habilitado = checkHabilitado.Checked;

            using (var context = new GD2C2018Entities())
            {
                foreach (string item in listaFuncionalidades.Seleccionadas)
                {
                    Funcionalidad func = (from f in context.Funcionalidad
                                          where f.Func_Descripcion == item
                                          select f).First();
                    rol.Funcionalidad.Add(func);
                }

                context.Entry(rol).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                ((RolesForm)Owner).ActualizarColor(rol);
                DataGrid.DataSource = context.Rol.ToList();
            }

            this.Close();           
        }

        private void AgregarEventosValidacion() {
            var ep = new ValidadorCampos(this);
            ep.AgregarCampo(boxNombre, ValidadorCampos.TipoValidacion.NotNull);
        }
    }
}
