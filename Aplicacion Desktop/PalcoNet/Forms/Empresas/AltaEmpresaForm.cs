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
    public partial class AltaEmpresaForm : Form
    {
        DataGridView DataGrid;
        private Espec_Empresa Nuevo = new Espec_Empresa();

        public AltaEmpresaForm(DataGridView dataGrid)
        {
            InitializeComponent();
            DataGrid = dataGrid;
            BindearCampos();

            boxRazon.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxCUIT.TextChanged += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            using (var context = new GD2C2018Entities())
            {
                Usuario u = AutogenerarUsuario();
                context.Entry(u).State = System.Data.Entity.EntityState.Added;
                context.Entry(Nuevo).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                DataGrid.DataSource = context.Espec_Empresa.ToList();
            }
            this.Close();

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void ValidarRequeridos(object sender, EventArgs e)
        {
            var razon = boxRazon.Text;
            var cuil = boxCUIT.Text;
            var mail = boxMail.Text;
            bool ok = razon.Length != 0 && cuil.Length != 0 && mail.Length != 0 && mail.Length != 0;
            botonCrear.Enabled = ok;
        }
        private void BindearCampos()
        {
            boxRazon.Bindear(Nuevo, "Espec_Empresa_Razon_Social");
            boxCUIT.Bindear(Nuevo, "Espec_Empresa_CUIT");
            boxMail.Bindear(Nuevo, "Espec_Empresa_Mail");
            boxTelefono.Bindear(Nuevo, "Espec_Empresa_Telefono");
            boxCalle.Bindear(Nuevo, "Espec_Empresa_Dom_Calle");
            boxNumero.Bindear(Nuevo, "Espec_Empresa_Nro_Calle");
            boxPiso.Bindear(Nuevo, "Espec_Empresa_Piso");
            boxDepartamento.Bindear(Nuevo, "Espec_Empresa_Depto");
            boxCodigoPostal.Bindear(Nuevo, "Espec_Empresa_Cod_Postal");
            boxLocalidad.Bindear(Nuevo, "Espec_Empresa_Localidad");
            boxCiudad.Bindear(Nuevo, "Espec_Empresa_Localidad");
        }

        private Usuario AutogenerarUsuario() {
            string contraseña = Utilidades.GenerarContraseña(4);
            Usuario usuario = new Usuario
            {
                Usuario_Autogenerado = true,
                Usuario_Habilitado = true,
                Usuario_Inicios = 0,
                Usuario_Intentos_Fallidos = 0,
                Usuario_Rol = "EMP",
                Usuario_Username = Utilidades.GenerarUsuario(6),
                Usuario_Password = Utilidades.SHA256Encrypt(contraseña)
            };
            Nuevo.Espec_Empresa_Usuario = usuario.Usuario_Username;
            MessageBox.Show("Nombre de usuario: " + usuario.Usuario_Username +
                "\nContraseña: " + contraseña +
                "\n\nTome constancia de estos datos e informe al usuario por mail",
                "Usuario autogenerado");
            return usuario;
        }
    }
}
