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
                .Property(f => f.CEP)
                .HasColumnName("CEP")
                .HasColumnType("char(9)");

            builder
                .Property(f => f.Logradouro)
                .HasColumnName("LOGRADOURO")
                .HasColumnType("varchar(150)");

            builder
                .Property(f => f.Numero)
                .HasColumnName("Numero")
                .HasColumnType("char(10)");

            builder
                .Property(f => f.Complemento)
                .HasColumnName("Complemento")
                .HasColumnType("varchar(50)");

            builder
                .Property(f => f.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("varchar(50)");

            builder
                .Property(f => f.Cidade)
                .HasColumnName("Cidade")
                .HasColumnType("varchar(50)");

            builder
                .Property(f => f.Estado)
                .HasColumnName("Estado")
                .HasColumnType("char(2)");

            builder
                .Property(f => f.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("varchar(11)");


            builder
                .Property(f => f.Email)
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(150)");
        }
    }
}
