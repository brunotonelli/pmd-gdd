//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PalcoNet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public decimal Cli_Dni { get; set; }
        public string Cli_Apellido { get; set; }
        public string Cli_Nombre { get; set; }
        public Nullable<System.DateTime> Cli_Fecha_Nac { get; set; }
        public string Cli_Mail { get; set; }
        public string Cli_Dom_Calle { get; set; }
        public Nullable<decimal> Cli_Nro_Calle { get; set; }
        public Nullable<decimal> Cli_Piso { get; set; }
        public string Cli_Depto { get; set; }
        public string Cli_Cod_Postal { get; set; }
        public string Cli_CUIL { get; set; }
        public string Cli_Telefono { get; set; }
        public string Cli_Localidad { get; set; }
        public Nullable<System.DateTime> Cli_Fecha_Alta { get; set; }
        public string Cli_Tarjeta_Num { get; set; }
        public string Cli_Tarjeta_Tipo { get; set; }
        public string Cli_Usuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
