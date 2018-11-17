using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Forms.Roles
{
    public partial class NuevoRolForm : Form
    {
        public NuevoRolForm() {
            InitializeComponent();
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
            }
            this.Close();
           
        }
    }
}
