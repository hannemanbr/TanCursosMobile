using System;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;

namespace TanCursos.Repository.EF.Context
{
    public class AppContext : DbContext 
    {
        public DbSet<TanCursosMobile.Domain.Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=tancursosapp.mysql.dbaas.com.br;Database=tancursosapp;user=tancursosapp;password=TanCursos2018");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
