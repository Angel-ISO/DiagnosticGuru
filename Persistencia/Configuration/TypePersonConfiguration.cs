using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class TypePersonConfiguration : IEntityTypeConfiguration<TypePerson>
    {
    public void Configure(EntityTypeBuilder<TypePerson> builder)
    {
        builder.ToTable("typepersons");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_typePerson")
                .HasColumnType("string")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

         

    }
}