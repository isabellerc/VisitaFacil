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
    public class IdosoConfiguration : IEntityTypeConfiguration<Idoso>
    {
        public void Configure(EntityTypeBuilder<Idoso> builder)
        {
            builder.ToTable("Idoso"); // Nome da tabela
            builder.HasKey(f => f.idIdoso); // Definir a chave primária

            builder
                .Property(f => f.idIdoso)
                .UseIdentityColumn()
                .HasColumnName("IDIDOSO")
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
                .Property(f => f.Telefone)
                .HasColumnName("TELEFONE")
                .HasColumnType("varchar(11)");

            builder
                .Property(f => f.Email)
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(150)");
        }
    }
}