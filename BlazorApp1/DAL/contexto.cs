using Microsoft.EntityFrameworkCore;
using BlazorApp1.Components.Layout.models;


namespace BlazorApp1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Tecnico> Tecnicos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tecnico>().HasIndex(t => t.Nombres).IsUnique();
        }
    }
}