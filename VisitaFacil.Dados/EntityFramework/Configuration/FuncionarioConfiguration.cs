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
            builder.ToTable("Funcionario");
            builder.HasKey(f => f.FuncionarioID);

            builder
                .Property(f => f.FuncionarioID)
                .UseIdentityColumn()
                .HasColumnName("FuncionarioID")
                .HasColumnType("int");

            builder
                .Property(f => f.CPF)
                .HasColumnName("CPF")
                .HasColumnType("char(11)");

            builder
                .Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)");

            builder
                .Property(f => f.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("date");

            builder
                .Property(f => f.Sexo)
                .HasColumnName("Sexo")
                .HasColumnType("char(1)");


        }
    }
}
