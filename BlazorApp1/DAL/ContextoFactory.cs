using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlazorApp1.DAL
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            optionsBuilder.UseSqlServer("workstation id=Gestiondetecnico.mssql.somee.com;packet size=4096;user id=pollote_SQLLogin_2;pwd=9ohsqjlghz;data source=Gestiondetecnico.mssql.somee.com;persist security info=False;initial catalog=Gestiondetecnico;TrustServerCertificate=True;");

            return new Contexto(optionsBuilder.Options);
        }
    }
}