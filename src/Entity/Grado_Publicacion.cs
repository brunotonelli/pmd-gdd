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
    
    public partial class Grado_Publicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grado_Publicacion()
        {
            this.Publicacion = new HashSet<Publicacion>();
        }
    
        public int Grado_ID { get; set; }
        public string Grado_Nombre { get; set; }
        public Nullable<decimal> Grado_Comision { get; set; }
        public Nullable<bool> Grado_Habilitado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publicacion> Publicacion { get; set; }
    }
}
