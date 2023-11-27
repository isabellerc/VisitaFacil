using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dados.EntityFramework.Configuration;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.Dados
{
    public class Contexto : DbContext

    {
        public DbSet<DadosPessoais> DadosPessoais { get; set; }
        public DbSet<Idoso> Idoso { get; set; }
        public Contexto() : base() { } //acho que ta repetindo o que eu acabei de colocar lá em cima
        public DbSet<Visitante> Visitante { get; set; }
        public DbSet<Visita> Visita { get; set; }

        //public DbSet<Usuario> Usuario { get; set; } 

        //vou comentar:
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //conexão para quando estiver fora do wifi da faculdade
            //optionsBuilder.UseSqlServer(
            //    "Data source=201.62.57.93,1434;Database=BD044263;User ID=RA044263;Password=044263;TrustServerCertificate=True",
            //    sqlServerOptionsAction: builder =>
            //    {
            //        builder.EnableRetryOnFailure(
            //            maxRetryCount: 2, // Número máximo de tentativas
            //            maxRetryDelay: TimeSpan.FromSeconds(10), // Atraso máximo entre as tentativas
            //            errorNumbersToAdd: null // Números de erro personalizados a serem adicionados
            //        );
            //    });

            //Conexão para quando estiver no wifi faculdade
            optionsBuilder.UseSqlServer(
            "Data source=bandeira,1434;Database=BD044263;User ID=RA044263;Password=044263;TrustServerCertificate=True",
                sqlServerOptionsAction: builder =>
                {
                    builder.EnableRetryOnFailure(
                        maxRetryCount: 2, // Número máximo de tentativas
                        maxRetryDelay: TimeSpan.FromSeconds(10), // Atraso máximo entre as tentativas
                        errorNumbersToAdd: null // Números de erro personalizados a serem adicionados
                    );
                });

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

          
            modelBuilder.ApplyConfiguration(new DadosPessoaisConfiguration());
            modelBuilder.ApplyConfiguration(new IdosoConfiguration());
            modelBuilder.ApplyConfiguration(new VisitanteConfiguration());
            modelBuilder.ApplyConfiguration(new VisitaConfiguration());
            //modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            //modelBuilder.Entity<RegistroVisita>().HasNoKey();
            //modelBuilder.ApplyConfiguration(new InstituicaoConfiguration());

            //modelBuilder.ApplyConfiguration(new LoginConfiguration());
            //modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            //modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            //modelBuilder.ApplyConfiguration(new VisitaConfiguration());

        }
    }
}


