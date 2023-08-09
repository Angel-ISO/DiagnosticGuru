using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class SpecialityConfiguration : IEntityTypeConfiguration<Speciality>
    {
    public void Configure(EntityTypeBuilder<Speciality> builder)
    {
        builder.ToTable("specialities");

            builder.Property(p => p.Id_Speciality)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Speciality")
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