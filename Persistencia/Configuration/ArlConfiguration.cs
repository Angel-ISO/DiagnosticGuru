using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class ArlConfiguration : IEntityTypeConfiguration<Arl>
    {
    public void Configure(EntityTypeBuilder<Arl> builder)
    {
        builder.ToTable("arls");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Arl")
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