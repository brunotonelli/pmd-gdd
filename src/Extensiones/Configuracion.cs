using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    public class Configuracion
    {
        //se levanta la config en un ConfigModel y se arma el connection string
        //eso se usa en el Context del ModeloDatos (se sobreescribe en el constructor el parametro default)
        public static string ConnectionString {
            get {
                return ArmarConnectionString(_config);
            }
        }

        public static DateTime FechaActual {
            get {
                return _config.FechaActual;
            }
        }

        private static ConfigModel _config;
        private static string _ruta = DecidirRuta() + "/Configuracion.json";

        public static ConfigModel Cargar() {

            if (!File.Exists(_ruta))
            {
                Reestablecer();
                MessageBox.Show("No se ha encontrado el archivo de configuración.\n" +
                    "Se ha creado el archivo predeterminado...");
            }
            string json = File.ReadAllText(_ruta);
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "dd-MM-yyyy";
            _config = JsonConvert.DeserializeObject<ConfigModel>(json, settings);
            return _config;
        }

        private static string ArmarConnectionString(ConfigModel c) {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = c.Servidor,
                InitialCatalog = c.BaseDeDatos,
                UserID = c.Usuario,
                Password = c.Contraseña
            };
            EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder()
            {
                Provider = "System.Data.SqlClient",
                Metadata = "res://*/Entity.ModeloDatos.csdl|res://*/Entity.ModeloDatos.ssdl|res://*/Entity.ModeloDatos.msl",
                ProviderConnectionString = sqlString.ToString()
            };
            return entityString.ConnectionString;
        }

        public static void Guardar(ConfigModel nuevaConfig) {
            using (StreamWriter sw = File.CreateText(_ruta))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.DateFormatString = "dd-MM-yyyy";
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(sw, nuevaConfig);
            }
            _config = nuevaConfig;
        }

        public static void Abrir() {
            if (!File.Exists(_ruta))
            {
                Reestablecer();
                MessageBox.Show("No se ha encontrado el archivo de configuración.\n" +
                    "Se ha creado el archivo predeterminado...");
            }
            Process.Start("notepad.exe", _ruta);
        }

        //en caso de que modifiquen el archivo y se olviden como era, esto lo devuelve a default
        public static void Reestablecer() {
            ConfigModel config = new ConfigModel
            {
                Servidor = "localhost\\SQLSERVER2012",
                BaseDeDatos = "GD2C2018",
                Usuario = "gdEspectaculos2018",
                Contraseña = "gd2018",
                FechaActual = DateTime.Now
            };
            Guardar(config);
        }

        //esto es porque la carpeta "src" del proyecto puede estar en otro lado no predeterminado 
        //en relacion al bin o archivo ejecutable
        private static string DecidirRuta() {
            var carpetaSource = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            if (carpetaSource != null)
                return carpetaSource.FullName;
            return Directory.GetCurrentDirectory();
        }
    }
}
