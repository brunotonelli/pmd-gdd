using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Forms
{
    public partial class ConfiguracionForm : Form
    {
        string Ruta = string.Empty;
        ConfigModel Config = new ConfigModel();

        public ConfiguracionForm() {
            InitializeComponent();
            Config = Configuracion.Cargar();
            LlenarCampos();
        }

        private void botonArchivo_Click(object sender, EventArgs e) {
            Configuracion.Abrir();
        }

        private void botonRestablecer_Click(object sender, EventArgs e) {
            Configuracion.Reestablecer();
            Config = Configuracion.Cargar();
            LlenarCampos();
        }

        private void botonGuardar_Click(object sender, EventArgs e) {
            ConfigModel nuevaConfig = new ConfigModel
            {
                Servidor = boxServidor.Text,
                BaseDeDatos = boxBaseDeDatos.Text,
                Usuario = boxUsuario.Text,
                Contraseña = boxContraseña.Text,
                FechaActual = boxFechaActual.Value
            };
            Configuracion.Guardar(nuevaConfig);
            MessageBox.Show("Configuración guardada con éxito.");
            this.Close();
        }
        
        private void LlenarCampos() {
            boxServidor.Text = Config.Servidor;
            boxBaseDeDatos.Text = Config.BaseDeDatos;
            boxUsuario.Text = Config.Usuario;
            boxContraseña.Text = Config.Contraseña;
            boxFechaActual.Value = Config.FechaActual;
        }

    }
}
