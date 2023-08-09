using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class TelephoneConfiguration : IEntityTypeConfiguration<Telephone>
    {
    public void Configure(EntityTypeBuilder<Telephone> builder)
    {
        builder.ToTable("telephones");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Telephone")
                .HasColumnType("int")
                .IsRequired();

            

        builder.Property(p => p.MobileNumber)
                .HasColumnName("Numero")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.Property(p => p.TelephoneNumber)
                .HasColumnName("Telefono")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

    }
}
