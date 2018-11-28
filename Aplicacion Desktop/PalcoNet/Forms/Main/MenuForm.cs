using PalcoNet.Forms;
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
    public partial class MenuForm : Form
    {
        public MenuForm(Usuario usuario) {
            InitializeComponent();
            var context = new GD2C2018Entities();
            Rol rol = (from r in context.Rol
                       where r.Rol_ID == usuario.Usuario_Rol
                       select r).First();
            this.labelUsuario.Text = usuario.Usuario_Username;
            this.labelRol.Text = rol.Rol_Nombre;
            ValidarFuncionalidades(rol);
        }

        private void ValidarFuncionalidades(Rol rol) {
            List<Funcionalidad> funcionalidades = rol.Funcionalidad.ToList();
            botonComprar.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("Comprar"));
            botonGenerar.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("Generar publicación"));
            botonEditar.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("Editar publicación"));
            botonClientes.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("ABM de Clientes"));
            botonEmpresas.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("ABM de Empresa de Espectáculos"));
            botonRoles.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("ABM de Rol"));
            botonRubros.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("ABM de Rubro"));
            botonGrados.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("ABM Grado de Publicación"));
            botonComisiones.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("Generar rendición de comisiones"));
            botonListado.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("Listado Estadistico"));
            botonHistorial.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("Historial de cliente"));
            botonPuntos.Enabled = funcionalidades.Any(f => f.Func_Descripcion.Equals("Canje y administración de puntos"));
        }

        private void botonClientes_Click(object sender, EventArgs e) {
            new ClientesForm().Show();
        }

        private void botonEmpresas_Click(object sender, EventArgs e) {
            new EmpresasForm().Show();
        }

        private void botonRoles_Click(object sender, EventArgs e) {
            new RolesForm().Show();
        }

        private void botonRubros_Click(object sender, EventArgs e) {
            new RubrosForm().Show();
        }

        private void botonGrados_Click(object sender, EventArgs e) {
            new GradosForm().Show();
        }

        private void botonComprar_Click(object sender, EventArgs e) {
            new ComprarForm().Show();
        }

        private void botonComisiones_Click(object sender, EventArgs e) {
            new ComisionesForm().Show();
        }

        private void botonListado_Click(object sender, EventArgs e)
        {
            new EstadisticasForm().Show();
        }

        private void botonGenerar_Click(object sender, EventArgs e) {
            new GenerarPublicacionForm().Show();
        }

        private void botonHistorial_Click(object sender, EventArgs e)
        {
            new HistorialComprasForm().Show();
        }
    }
}
