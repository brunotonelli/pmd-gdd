﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GD2C2018Entities : DbContext
    {
        public GD2C2018Entities()
            : base(Configuracion.ConnectionString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Espec_Empresa> Espec_Empresa { get; set; }
        public virtual DbSet<Espectaculo> Espectaculo { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Funcionalidad> Funcionalidad { get; set; }
        public virtual DbSet<Grado_Publicacion> Grado_Publicacion { get; set; }
        public virtual DbSet<Item_Factura> Item_Factura { get; set; }
        public virtual DbSet<Premio> Premio { get; set; }
        public virtual DbSet<Premio_X_Cliente> Premio_X_Cliente { get; set; }
        public virtual DbSet<Publicacion> Publicacion { get; set; }
        public virtual DbSet<Puntos> Puntos { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Rubro> Rubro { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
    }
}
