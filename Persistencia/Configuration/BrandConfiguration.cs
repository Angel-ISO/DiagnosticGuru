using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("brand");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Brand")
                .HasColumnType("int")
                .IsRequired();

            

        builder.Property(p => p.Description)
                .HasColumnName("Namebrand")
                .HasColumnType("varchar")
                .HasMaxLength(200);

    }
}