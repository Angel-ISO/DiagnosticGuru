using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("rols");

            builder.Property(p => p.Id_Rol)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Rol")
                .HasColumnType("int")
                .IsRequired();

            

        builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

    }
}