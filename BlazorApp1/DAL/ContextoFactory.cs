using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlazorApp1.DAL
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            optionsBuilder.UseSqlServer("Server=GestionTecnico.mssql.somee.com;packet size=4096;user id=pollotemore_SQLLogin_1;pwd=89zy54g4e2;data source=GestionTecnico.mssql.somee.com;persist security info=False;initial catalog=GestionTecnico;TrustServerCertificate=True;");

            return new Contexto(optionsBuilder.Options);
        }
    }
}