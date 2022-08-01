using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TesteGTI.WebbApi.Entidades;

namespace TesteGTI.WebbApi.Data
{
    public class TesteGTIDbContext : DbContext
    {
        public List<string> Ufs = new List<string> {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES",
        "GO","MA","MT","MS", "MG","PA", "PB","PR","PE", "PI", "RJ", "RN", "RS", "RO", "RR","SC", "SP",
        "SE", "TO"};
        public TesteGTIDbContext(DbContextOptions<TesteGTIDbContext> options) : base(options)
        { }


        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<EnderecoCliente> Endereco { get; set; }
        public DbSet<UFs> UFs { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }

        public DbSet<SexoCliente> SexoCliente { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UFs>(modelBuilder =>
            {
                modelBuilder.HasData(
                    Ufs.Select(x => new UFs
                    {
                        Id = Ufs.FindIndex(y => x == y) + 1,
                        Nome = x
                    })
                );
            });

            builder.Entity<EstadoCivil>(modelBuilder =>
            {
                modelBuilder.HasData(
                    new EstadoCivil
                    {
                        Id = 1,
                        Descricao = "Casado(a)"
                    },
                     new EstadoCivil
                     {
                         Id = 2,
                         Descricao = "Solteiro(a)"
                     },
                      new EstadoCivil
                      {
                          Id = 3,
                          Descricao = "Viúvo(a)"
                      },
                      new EstadoCivil
                      {
                          Id = 4,
                          Descricao = "Divorciado(a)"
                      },
                      new EstadoCivil
                      {
                          Id = 5,
                          Descricao = "União Estável"
                      }
                );
            });

            builder.Entity<SexoCliente>(modelBuilder =>
            {
                modelBuilder.HasData(
                    new SexoCliente
                    {
                        Id = 1,
                        Nome = "Feminino"
                    },
                    new SexoCliente
                    {
                        Id = 2,
                        Nome = "Masculino"
                    },
                    new SexoCliente
                    {
                        Id = 3,
                        Nome = "Prefiro não declarar"
                    }

             );
            });

        }
    }
}

