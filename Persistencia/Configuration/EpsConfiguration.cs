using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class EpsConfiguration : IEntityTypeConfiguration<Eps>
    {
    public void Configure(EntityTypeBuilder<Eps> builder)
    {
        builder.ToTable("eps");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Eps")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();

            

        builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

    }
}