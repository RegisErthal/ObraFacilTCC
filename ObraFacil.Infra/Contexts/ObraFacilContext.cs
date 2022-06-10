using Microsoft.EntityFrameworkCore;
using ObraFacil.Infra.Entities;

namespace ObraFacil.Infra.Contexts
{
    public class ObraFacilContext : DbContext
    {
        private readonly string _connectionString;

        public ObraFacilContext()
        { 
        }
        public ObraFacilContext(string connectionString)
            {
                _connectionString = connectionString;
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySQL(_connectionString ?? "Server=localhost;Port=3306;Database=dbobrafacil;Uid=root;Pwd=etapas;");
            }

            //public virtual DbSet<AlvenariaModel> Alvenaria { get; set; }
            //public virtual DbSet<CoberturaModel> Cobertura { get; set; }
            //public virtual DbSet<EletricaModel> Eletrica { get; set; }
            //public virtual DbSet<HidraulicaModel> Hidraulica { get; set; }
            public virtual DbSet<FundacaoModel> Fundacao { get; set; }
            public virtual DbSet<ClientEntity> Clients { get; set; }
    }
}
