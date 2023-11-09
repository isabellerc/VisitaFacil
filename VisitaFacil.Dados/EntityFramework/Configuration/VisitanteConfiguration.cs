using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.Dados.EntityFramework.Configuration
{
    public class VisitanteConfiguration : IEntityTypeConfiguration<Visitante>
    {
        public void Configure(EntityTypeBuilder<Visitante> builder)
        {
            builder.ToTable("Visitante"); // Nome da tabela
            builder.HasKey(f => f.idVisitante); // Definir a chave primária

            builder
                .Property(f => f.idVisitante)
                .UseIdentityColumn()
                .HasColumnName("ID")
                .HasColumnType("int");

            // Configuração das colunas
            builder
                .Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasColumnType("nvarchar(255)")
                .IsRequired();

            builder
                .Property(f => f.Cpf)
                .HasColumnName("Cpf")
                .HasColumnType("char(11)")
                .IsRequired();

            builder
                .Property(f => f.dataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date");

            builder
                .Property(f => f.Endereco)
                .HasColumnName("Endereco")
                .HasColumnType("nvarchar(255)");

            builder
                .Property(f => f.Telefone1)
                .HasColumnName("Telefone1")
                .HasColumnType("nvarchar(20)");

            builder
                .Property(f => f.Telefone2)
                .HasColumnName("Telefone2")
                .HasColumnType("nvarchar(20)");

            builder
                .Property(f => f.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(255)");
        }
    }
}
