//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PalcoNet.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Espectaculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Espectaculo()
        {
            this.Publicacion = new HashSet<Publicacion>();
        }
    
        public decimal Espectaculo_Cod { get; set; }
        public string Espectaculo_Descripcion { get; set; }
        public Nullable<int> Espectaculo_Rubro { get; set; }
        public string Espectaculo_Direccion { get; set; }
    
        public virtual Rubro Rubro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publicacion> Publicacion { get; set; }
    }
}