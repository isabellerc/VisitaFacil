using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dominio;

namespace VisitaFacil.Dados
{
    public class Contexto : DbContext

        // criar isso abaixo para cada tabela
    {
        public DbSet<Endereco> Endereco { get; set; }
        public Contexto() : base() { }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93:1434;
                                   DataBase = DB043411;
                                   User ID = RA043411;
                                   Password = 043411;
                                   TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
        }
    }
}

