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

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Speciality")
                .HasColumnType("int")
                .IsRequired();

            

        builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

    }
}