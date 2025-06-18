using BlazorApp1.models;
using Microsoft.EntityFrameworkCore;


namespace BlazorApp1.DAL
{
    public class Contexto : DbContext
    {
        
        public virtual DbSet<Sistemas> Sistemas { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

       
    }
}