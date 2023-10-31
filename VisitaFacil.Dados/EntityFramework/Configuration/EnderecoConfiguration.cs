using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dominio;

namespace VisitaFacil.Dados
{
    //public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    //{
    //    public void Configure(EntityTypeBuilder<Endereco> builder)
    //    {
    //        builder.ToTable("Endereco");
    //        builder.HasKey(f => f.EnderecoID);

    //        builder.HasKey(F=> new {f})
    //        builder.ToTable("Endereco");
    //        builder.Property(f=> f.logradouro)
    //            .HasColumnNome("logradouro")
    //            .HasColumnType("string")


    //               public string logradouro { get; set; }
    //    public int numero { get; set; }
    //    public string bairro { get; set; }
    //    public string complemento { get; set; }
    //    public string cidade { get; set; }
    //    public string estado { get; set; }
    //}
    //}
}
