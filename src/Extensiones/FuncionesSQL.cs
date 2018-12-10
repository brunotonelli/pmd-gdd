using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Extensiones
{
    //clase necesaria para poder usar las Functions de la DB en LINQ to entities / EF6
    public static class FuncionesSQL
    {
        [DbFunction("GD2C2018Model.Store", "localidadesVendidas")]
        public static int LocalidadesVendidas(string idEmpresa, int ano, int trimestre) {
            throw new NotSupportedException("Direct calls are not supported.");
        }

        [DbFunction("GD2C2018Model.Store", "localidadesTotales")]
        public static int LocalidadesTotales(string idEmpresa, int ano, int trimestre) {
            throw new NotSupportedException("Direct calls are not supported.");
        }
    }
}
