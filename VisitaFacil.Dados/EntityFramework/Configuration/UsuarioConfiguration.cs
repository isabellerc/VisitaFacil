//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace VisitaFacil.Dados.EntityFramework.Configuration
//{
//    public class UsuarioConfiguration
//    {
//        builder.ToTable("Usuario"); // Nome da tabela
//            builder.HasKey(f => f.ID); // Definir a chave primária

//            builder
//                .Property(f => f.ID)
//                .UseIdentityColumn()
//                .HasColumnName("ID")
//                .HasColumnType("int");
//        builder
//               .Property(f => f.Email)
//                .HasColumnName("Email")
//                .HasColumnType("nvarchar(255)");
//    }
//}
