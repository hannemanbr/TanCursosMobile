using System;
using Microsoft.EntityFrameworkCore;
using TanCursos.Repository.EF.Context;
using TanCursosMobile.Domain;

namespace TanCursos.Repository.EF.Mapping
{
    public class PessoaMap : Context.AppContext
    {
        public PessoaMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(ent =>
            {
                ent.HasKey(e => e.Id);
                ent.Property(e => e.Nome).HasColumnName("Nome");
            });
        }
    }
}
