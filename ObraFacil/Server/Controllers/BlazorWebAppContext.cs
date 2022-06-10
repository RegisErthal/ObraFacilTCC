using Microsoft.EntityFrameworkCore;
using ObraFacil.Infra.Entities;


namespace ObraFacil.Infra.Controllers
{
    public class BlazorWebAppContext : DbContext
    {
        private readonly string _connectionString;

        public BlazorWebAppContext()
        {
        }

        public BlazorWebAppContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionString ?? "Server=localhost;Port=3306;Database=dbobrafacil;Uid=root;Pwd=etapas;");
        }

        public virtual DbSet<ClientEntity> Clients { get; set; }
    }
}