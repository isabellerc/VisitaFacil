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
        //vou comentar:
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
       

        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Idoso> Idoso { get; set; }
        public DbSet<ParenteProximo> Parente { get; set; } 
        public DbSet<Visitante> Visitante { get; set; }
        //public DbSet<Login> Login { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<RegistroVisita> RegistroVisita { get; set; }
        public DbSet<DadosPessoais> DadosPessoais { get; set; }
        
        public Contexto() : base() { } //acho que ta repetindo o que eu acabei de colocar lá em cima


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data source=201.62.57.93,1434;Database=DB044263;User ID=RA044263;Password=044263;TrustServerCertificate=True",
                sqlServerOptionsAction: builder =>
                {
                    builder.EnableRetryOnFailure(
                        maxRetryCount: 10, // Número máximo de tentativas
                        maxRetryDelay: TimeSpan.FromSeconds(30), // Atraso máximo entre as tentativas
                        errorNumbersToAdd: null // Números de erro personalizados a serem adicionados
                    );
                });

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new DadosPessoaisConfiguration());
            modelBuilder.Entity<RegistroVisita>().HasNoKey();
            //modelBuilder.ApplyConfiguration(new InstituicaoConfiguration());
            //modelBuilder.ApplyConfiguration(new IdosoConfiguration());
            //modelBuilder.ApplyConfiguration(new ParenteProximoConfiguration());
            //modelBuilder.ApplyConfiguration(new VisitanteConfiguration());
            //modelBuilder.ApplyConfiguration(new LoginConfiguration());
            //modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            //modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            //modelBuilder.ApplyConfiguration(new VisitaConfiguration());

        }
    }
}

