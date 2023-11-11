using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.Dados.EntityFramework.Configuration
{
    public class VisitaConfiguration : IEntityTypeConfiguration<Visita>
    {
        public void Configure(EntityTypeBuilder<Visita> builder)
        {
            builder.ToTable("Visita"); // Nome da tabela
            builder.HasKey(f => f.idVisita); // Definir a chave primária

            builder
                .Property(f => f.idVisita)
                .UseIdentityColumn()
                .HasColumnName("IDVISITA")
                .HasColumnType("int");

            // Configuração das colunas
            builder
                .Property(f => f.idIdoso)
                .HasColumnName("IDIDOSO")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(f => f.idVisitante)
                .HasColumnName("IDVISITANTE")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(f => f.dataVisita)
                .HasColumnName("DATAVISITA")
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(f => f.horaEntrada)
                .HasColumnName("HORAENTRADA")
                .HasColumnType("datetime")
                .IsRequired();

            builder
                .Property(f => f.horaSaida)
                .HasColumnName("HORASAIDA")
                .HasColumnType("datetime")
                .IsRequired();

            // Relacionamentos
            builder
                .HasOne(v => v.Idoso)
                .WithMany(i => i.Visitas)
                .HasForeignKey(v => v.idIdoso)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(v => v.Visitante)
                .WithMany()
                .HasForeignKey(v => v.idVisitante)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
