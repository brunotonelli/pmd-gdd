﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
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
            : base("name=GD2C2018Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Espec_Empresa> Espec_Empresa { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Funcionalidad> Funcionalidad { get; set; }
        public DbSet<Grado_Publicacion> Grado_Publicacion { get; set; }
        public DbSet<Item_Factura> Item_Factura { get; set; }
        public DbSet<Premio> Premio { get; set; }
        public DbSet<Puntos> Puntos { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Rubro> Rubro { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<Espectaculo> Espectaculo { get; set; }
        public DbSet<Publicacion> Publicacion { get; set; }
    }
}
