﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PruebaTecnicaISOMARCAPITALEntities : DbContext
    {
        public PruebaTecnicaISOMARCAPITALEntities()
            : base("name=PruebaTecnicaISOMARCAPITALEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int MaletaAdd(Nullable<int> idMaleta, string modelo, string marca, string altura, string ancho, Nullable<int> unidad)
        {
            var idMaletaParameter = idMaleta.HasValue ?
                new ObjectParameter("IdMaleta", idMaleta) :
                new ObjectParameter("IdMaleta", typeof(int));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("Modelo", modelo) :
                new ObjectParameter("Modelo", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            var alturaParameter = altura != null ?
                new ObjectParameter("Altura", altura) :
                new ObjectParameter("Altura", typeof(string));
    
            var anchoParameter = ancho != null ?
                new ObjectParameter("Ancho", ancho) :
                new ObjectParameter("Ancho", typeof(string));
    
            var unidadParameter = unidad.HasValue ?
                new ObjectParameter("Unidad", unidad) :
                new ObjectParameter("Unidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MaletaAdd", idMaletaParameter, modeloParameter, marcaParameter, alturaParameter, anchoParameter, unidadParameter);
        }
    }
}
