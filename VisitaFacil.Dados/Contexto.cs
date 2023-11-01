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

        // criar isso abaixo para cada tabela
    {
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Idoso> Idoso { get; set; }
        public DbSet<Visitante> Visitante { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Visita> RegistroVisita { get; set; }
        public Contexto() : base() { }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93:1434;
                                   DataBase = DB044263;
                                   User ID = RA044263;
                                   Password = 044263;
                                   TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
        }
    }
}

