﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoPropietaria
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RentCarEntities1 : DbContext
    {
        public RentCarEntities1()
            : base("name=RentCarEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<COMBUSTIBLE_VEHICULO> COMBUSTIBLE_VEHICULO { get; set; }
        public virtual DbSet<EMPLEADO> EMPLEADO { get; set; }
        public virtual DbSet<INSPECCION> INSPECCION { get; set; }
        public virtual DbSet<INSPECCION_GOMAS> INSPECCION_GOMAS { get; set; }
        public virtual DbSet<MARCA_VEHICULO> MARCA_VEHICULO { get; set; }
        public virtual DbSet<MODELO_VEHICULO> MODELO_VEHICULO { get; set; }
        public virtual DbSet<RENTA> RENTA { get; set; }
        public virtual DbSet<TIPO_VEHICULO> TIPO_VEHICULO { get; set; }
        public virtual DbSet<VEHICULO> VEHICULO { get; set; }
    }
}
