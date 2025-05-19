using Microsoft.EntityFrameworkCore;
using BlazorApp1.Components.models;

namespace BlazorApp1.Components.Layout.DAL
{
    public class ContextoPrueba : DbContext
    {
        public ContextoPrueba(DbContextOptions<ContextoPrueba> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp1.Components.models.Tecnico> Tecnicos { get; set; }
    }
}