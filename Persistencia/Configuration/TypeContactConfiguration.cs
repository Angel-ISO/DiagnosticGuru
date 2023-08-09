using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class TypeContactConfiguration : IEntityTypeConfiguration<TypeContact>
    {
    public void Configure(EntityTypeBuilder<TypeContact> builder)
    {
        builder.ToTable("typecontacts");

            builder.Property(p => p.Id_TypeContact)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_TypeContact")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();

             builder.Property(p => p.Email)
                .HasColumnName("email")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


         builder.HasOne(p => p.Telephone)
                .WithMany(p => p.TypeContacts)
                .HasForeignKey(p => p.Id_Telephone);
                
    
    }
}