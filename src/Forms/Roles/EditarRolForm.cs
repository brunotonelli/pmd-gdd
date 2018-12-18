using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Validaciones;

namespace PalcoNet.Forms
{
    public partial class EditarRolForm : Form
    {
        private GD2C2018Entities Context;
        private Rol Rol;

        public EditarRolForm(Rol rol, GD2C2018Entities context)
        {
            Rol = rol;
            Context = context;
            InitializeComponent();
            AgregarEventosValidacion();
            CargarDatos();
            CargarFuncionalidades();
        }

        private void CargarDatos()
        {
            boxCodigo.Text = Rol.Rol_ID;
            boxNombre.Text = Rol.Rol_Nombre;
            checkHabilitado.Checked = Rol.Rol_Habilitado.Value;
        }

        private void CargarFuncionalidades()
        {
            var funcionalidades = Rol.Funcionalidad.ToList();
            funcionalidades.ForEach(f => listaFuncionalidades.Seleccionar(f.Func_Descripcion));
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Rol.Rol_Nombre = boxNombre.Text;
            Rol.Rol_Habilitado = checkHabilitado.Checked;
            Rol.Funcionalidad.Clear();
            Context.Entry(Rol).State = System.Data.Entity.EntityState.Modified;            

            foreach (string item in listaFuncionalidades.Seleccionadas)
            {
                Funcionalidad func = (from f in Context.Funcionalidad
                                      where f.Func_Descripcion == item
                                      select f).First();
                Rol.Funcionalidad.Add(func);
            }

            Context.SaveChanges();

            var owner = (RolesForm)Owner;
            owner.ActualizarGrid();
            this.Close();     
        }

        private void AgregarEventosValidacion()
        {
            var ep = new ValidadorCampos(this);
            ep.AgregarCampo(boxNombre, ValidadorCampos.TipoValidacion.NotNull);
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
