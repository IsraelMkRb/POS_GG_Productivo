﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GemaEntities1 : DbContext
    {
        public GemaEntities1()
            : base("name=GemaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<general_Articulo_Modificador_Dtl> general_Articulo_Modificador_Dtl { get; set; }
        public virtual DbSet<empleados_login_dtl> empleados_login_dtl { get; set; }
        public virtual DbSet<general_Articulos> general_Articulos { get; set; }
        public virtual DbSet<empleados_tokens> empleados_tokens { get; set; }
        public virtual DbSet<general_Modificadores> general_Modificadores { get; set; }
    
        public virtual int RegistraToken(string token, Nullable<System.DateTime> fechafin)
        {
            var tokenParameter = token != null ?
                new ObjectParameter("token", token) :
                new ObjectParameter("token", typeof(string));
    
            var fechafinParameter = fechafin.HasValue ?
                new ObjectParameter("fechafin", fechafin) :
                new ObjectParameter("fechafin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistraToken", tokenParameter, fechafinParameter);
        }
    
        public virtual int ActualizaEstadoToken(Nullable<System.DateTime> nuevafecha, string token)
        {
            var nuevafechaParameter = nuevafecha.HasValue ?
                new ObjectParameter("nuevafecha", nuevafecha) :
                new ObjectParameter("nuevafecha", typeof(System.DateTime));
    
            var tokenParameter = token != null ?
                new ObjectParameter("token", token) :
                new ObjectParameter("token", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizaEstadoToken", nuevafechaParameter, tokenParameter);
        }
    }
}
