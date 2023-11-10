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
                .HasColumnName("IDVISITANTE")
                .HasColumnType("int");

            // Configuração das colunas
            builder
                .Property(f => f.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(f => f.Cpf)
                .HasColumnName("CPF")
                .HasColumnType("char(11)")
                .IsRequired();

            builder
                .Property(f => f.dataNascimento)
                .HasColumnName("DATANASCIMENTO")
                .HasColumnType("date");

            builder
                .Property(f => f.Endereco)
                .HasColumnName("ENDERECO")
                .HasColumnType("varchar(500)");

            builder
                .Property(f => f.Telefone1)
                .HasColumnName("TELEFONE1")
                .HasColumnType("varchar(11)");

            builder
                .Property(f => f.Telefone2)
                .HasColumnName("TELEFONE2")
                .HasColumnType("varchar(11)");

            builder
                .Property(f => f.Email)
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(150)");
        }
    }
}
