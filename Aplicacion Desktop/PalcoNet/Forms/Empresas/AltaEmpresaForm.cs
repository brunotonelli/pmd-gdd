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
            boxRazon.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxCUIT.TextChanged += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            bool existeEmpresa = Validaciones.ExisteEmpresa(boxRazon.Text, boxCUIT.Text);
            bool cuitValido = Validaciones.CUILValido(boxCUIT.Text);

            if (existeEmpresa)
                MessageBox.Show("Ya existe una empresa con esa razón social o CUIT", "Error de Empresa");
            if (!cuitValido)
                MessageBox.Show("El CUIL ingresado no tiene el formado correcto\nEjemplo: ##-########-#", "Error de CUIL");

            if (!existeEmpresa && cuitValido)
            {
                BindearDatos();
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
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindearDatos() {
            Nuevo.Espec_Empresa_Ciudad = boxCiudad.Text;
            Nuevo.Espec_Empresa_Cod_Postal = boxCodigoPostal.Text;
            Nuevo.Espec_Empresa_Cuit = boxCUIT.Text;
            Nuevo.Espec_Empresa_Depto = boxDepartamento.Text;
            Nuevo.Espec_Empresa_Dom_Calle = boxCalle.Text;
            Nuevo.Espec_Empresa_Habilitado = true;
            Nuevo.Espec_Empresa_Localidad = boxLocalidad.Text;
            Nuevo.Espec_Empresa_Mail = boxMail.Text;
            Nuevo.Espec_Empresa_Nro_Calle = decimal.Parse(boxNumero.Text);
            Nuevo.Espec_Empresa_Piso = decimal.Parse(boxPiso.Text);
            Nuevo.Espec_Empresa_Razon_Social = boxRazon.Text;
            Nuevo.Espec_Empresa_Telefono = boxTelefono.Text;
            Nuevo.Espec_Empresa_Fecha_Creacion = Properties.Settings.Default.FechaActual;
        }

        private void ValidarRequeridos(object sender, EventArgs e)
        {
            var razon = boxRazon.Text;
            var cuil = boxCUIT.Text;
            var mail = boxMail.Text;
            bool ok = razon.Length != 0 && cuil.Length != 0 && mail.Length != 0 && mail.Length != 0;
            botonCrear.Enabled = ok;
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
