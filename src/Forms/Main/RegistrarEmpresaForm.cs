﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Extensiones;
using PalcoNet.Validaciones;

namespace PalcoNet.Forms
{
    public partial class RegistrarEmpresaForm : Form
    {
        public RegistrarEmpresaForm()
        {
            InitializeComponent();
            AgregarEventosValidacion();
        }

        private void ValidarRequeridos(object sender, EventArgs e)
        {
            var razon = boxRazon.Text;
            var cuit = boxCUIT.Text;
            var mail = boxMail.Text;
            var usuario = boxUsuario.Text;
            var contraseña = boxContraseña.Text;
            bool ok = razon.Length != 0 && cuit.Length != 0 && mail.Length != 0 &&
                usuario.Length != 0 && contraseña.Length != 0;
            botonRegistrarse.Enabled = ok;
        }

        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            bool existeUsuario = ValidacionesInput.ExisteUsuario(boxUsuario.Text);
            bool existeEmpresa = ValidacionesInput.ExisteEmpresa(boxRazon.Text, boxCUIT.Text);
            bool cuitValido = ValidacionesInput.CUILValido(boxCUIT.Text);

            if (existeUsuario)
                MessageBox.Show("Ese nombre de usuario ya se encuentra en uso", "Error de Usuario");
            if (existeEmpresa)
                MessageBox.Show("Ya existe una empresa con esa razón social o CUIT", "Error de Empresa");
            if (!cuitValido)
                MessageBox.Show("El CUIL ingresado no tiene el formado correcto\nEjemplo: ##-########-#", "Error de CUIL");

            if (!existeUsuario && !existeEmpresa && cuitValido)
            {
                var context = new GD2C2018Entities();

                Usuario usuario = new Usuario
                {
                    Usuario_Username = boxUsuario.Text,
                    Usuario_Password = Utilidades.SHA256Encrypt(boxContraseña.Text),
                    Usuario_Intentos_Fallidos = 0,
                    Usuario_Autogenerado = false
                };
                
                var piso = boxPiso.Text.Length > 0 ? decimal.Parse(boxPiso.Text) : 0;
                var nroCalle = boxNumero.Text.Length > 0 ? decimal.Parse(boxNumero.Text) : 0;

                Espec_Empresa empresa = new Espec_Empresa
                {
                    Espec_Empresa_Fecha_Creacion = DateTime.Now,
                    Espec_Empresa_Razon_Social = boxRazon.Text,
                    Espec_Empresa_Cuit = boxCUIT.Text,
                    Espec_Empresa_Mail = boxMail.Text,
                    Espec_Empresa_Dom_Calle = boxCalle.Text,
                    Espec_Empresa_Nro_Calle = piso,
                    Espec_Empresa_Telefono = boxTelefono.Text,
                    Espec_Empresa_Localidad = boxLocalidad.Text,
                    Espec_Empresa_Cod_Postal = boxCodigoPostal.Text,
                    Espec_Empresa_Depto = boxDepartamento.Text,
                    Espec_Empresa_Ciudad = boxCiudad.Text,
                    Espec_Empresa_Piso = nroCalle,
                    Espec_Empresa_Usuario = boxUsuario.Text,
                    Espec_Empresa_Habilitado = true
                };

                context.Entry(usuario).State = System.Data.Entity.EntityState.Added;
                context.Entry(empresa).State = System.Data.Entity.EntityState.Added;

                var rol = context.Rol.Single(r => r.Rol_ID == "EMP");                
                usuario.Rol.Add(rol);
                context.SaveChanges();        
                
                MessageBox.Show("Usuario creado con éxito!", "Registro de usuario");
                Sesion.LogIn(usuario, rol);
                var menu = MenuForm.ObtenerInstancia(rol);
                FormsEstaticos.Principal.Hide();
                this.Close();
                menu.Show();
            }
        }

        private void AgregarEventosValidacion() {
            var ep = new ValidadorCampos(this);
            ep.AgregarCampo(boxPiso, ValidadorCampos.TipoValidacion.Numerica);
            ep.AgregarCampo(boxNumero, ValidadorCampos.TipoValidacion.Numerica);
            boxRazon.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxCUIT.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxMail.TextChangeEvent += new EventHandler(ValidarRequeridos);
            boxUsuario.TextChanged += new EventHandler(ValidarRequeridos);
            boxContraseña.TextChanged += new EventHandler(ValidarRequeridos);
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
