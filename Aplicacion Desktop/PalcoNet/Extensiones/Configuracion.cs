using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Extensiones
{
    public class Configuracion
    {
        private static Configuracion instance = null;

        public string ConnectionString { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Fecha { get; set; }

        private Configuracion() { }

        public static Configuracion Instancia {
            get {
                if (instance == null)
                {
                    StreamReader r = new StreamReader("../config.json");
                    string json = r.ReadToEnd();
                    Configuracion config = JsonConvert.DeserializeObject<Configuracion>(json);
                    instance = new Configuracion();
                    instance.ConnectionString = config.ConnectionString;
                    instance.Username = config.Username;
                    instance.Password = config.Password;
                    instance.Fecha = config.Fecha;
                }
                return instance;
            }
        }
    }


}
