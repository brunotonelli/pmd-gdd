using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Extensiones
{
    public static class ConsultasDB
    {
        public static Rol GetRol(string id) {
            return new GD2C2018Entities().Rol.Single(r => r.Rol_ID == id);
        }
    }
}
