using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Extensiones
{
    //basicamente en esta clase son GETS de entidades, pasandole el id nada mas
    public static class ConsultasDB {
        public static Rol GetRol(string id) {
            return new GD2C2018Entities().Rol.Single(r => r.Rol_ID == id);
        }

        public static Espec_Empresa GetEmpresa(string cuit) {
            return new GD2C2018Entities().Espec_Empresa.Single(e => e.Espec_Empresa_Cuit == cuit);
        }

        public static Estado GetEstado(int id) {
            return new GD2C2018Entities().Estado.Single(e => e.Estado_ID == id);
        }

        public static int GetEstado(string descripcion) {
            return new GD2C2018Entities().Estado.Single(e => e.Estado_Descripcion == descripcion).Estado_ID;
        }

        public static Espectaculo GetEspectaculo(decimal id) {
            return new GD2C2018Entities().Espectaculo.Single(e => e.Espectaculo_Cod == id);
        }

        public static Grado_Publicacion GetGrado(int id) {
            return new GD2C2018Entities().Grado_Publicacion.Single(g => g.Grado_ID == id);
        }

        public static int GetGrado(string descripcion) {
            return new GD2C2018Entities().Grado_Publicacion.Single(g => g.Grado_Nombre == descripcion).Grado_ID;
        }

        public static Rubro GetRubro(int id) {
            return new GD2C2018Entities().Rubro.Single(r => r.Rubro_ID == id);
        }

        public static int GetRubro(string descripcion) {
            return new GD2C2018Entities().Rubro.Single(r => r.Rubro_Descripcion == descripcion).Rubro_ID;
        }
    }
}
