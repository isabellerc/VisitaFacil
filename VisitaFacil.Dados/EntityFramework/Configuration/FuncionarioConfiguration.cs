using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.Dados.EntityFramework.Configuration
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("FUNCIONARIO", "dbo");
            //builder.HasKey("IDFUNCIONARIO");

            //builder
            //    .Property(f => f.IDFUNCIONARIO)
            //    .UseIdentityColumn();
            //    //.HasColumnName("idFuncionario")
            //    //.HasColumnType("int");

            builder
                .Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(200)");

            builder
                .Property(f => f.Cpf)
                .HasColumnName("Cpf")
                .HasColumnType("char(11)");

            builder
                .Property(f => f.dataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date");

            builder
                .Property(f => f.Telefone1)
                .HasColumnName("Telefone1")
                .HasColumnType("varchar(11)");

            builder
                .Property(f => f.Telefone2)
                .HasColumnName("Telefone2")
                .HasColumnType("varchar(11)");

            builder
                .Property(f => f.Email)
                .HasColumnName("Telefone2")
                .HasColumnType("varchar(150)");

            builder
                .Property(f => f.Ativo)
                .HasColumnName("Telefone2")
                .HasColumnType("char(1)");
        }
    }
}
