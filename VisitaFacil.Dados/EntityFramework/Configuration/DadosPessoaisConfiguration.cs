using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dominio.Entities;
using VisitaFacil.Dados.EntityFramework.Configuration;
using VisitaFacil.Dados;

namespace VisitaFacil.Dados.EntityFramework.Configuration
{
    public class DadosPessoaisConfiguration : IEntityTypeConfiguration<DadosPessoais>
    {
        public void Configure(EntityTypeBuilder<DadosPessoais> builder)
        {
            builder.ToTable("DadosPessoais"); // Nome da tabela
            builder.HasKey(f => f.ID); // Definir a chave primária

            builder
                .Property(f => f.ID)
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
                .HasColumnType("nvarchar(20)")
                .IsRequired();

            builder
                .Property(f => f.dataNascimento)
                .HasColumnName("DataNascimento")
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
                .HasColumnType("nvarchar(20)");

            builder
                .Property(f => f.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar(255)");

            // Outras configurações, como índices, restrições, etc., podem ser adicionadas aqui conforme necessário.
        }

    }
}
