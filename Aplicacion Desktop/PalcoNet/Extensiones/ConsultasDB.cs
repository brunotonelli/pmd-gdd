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

        public static Espec_Empresa GetEmpresa(string cuit) {
            return new GD2C2018Entities().Espec_Empresa.Single(e => e.Espec_Empresa_Cuit == cuit);
        }

        public static Estado GetEstado(int id) {
            return new GD2C2018Entities().Estado.Single(e => e.Estado_ID == id);
        }

        public static Espectaculo GetEspectaculo(decimal id) {
            return new GD2C2018Entities().Espectaculo.Single(e => e.Espectaculo_Cod == id);
        }

        public static Grado_Publicacion GetGrado(int id) {
            return new GD2C2018Entities().Grado_Publicacion.Single(g => g.Grado_ID == id);
        }
    }
}
