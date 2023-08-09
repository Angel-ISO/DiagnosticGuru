using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class RadioConfiguration : IEntityTypeConfiguration<Radio>
    {
    public void Configure(EntityTypeBuilder<Radio> builder)
    {
        builder.ToTable("radio");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Radio")
                .HasColumnType("string")
                .HasMaxLength(200)
                .IsRequired();

                  builder.Property(p => p.Brand)
                .HasColumnName("NameBrand")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.Property(p => p.State)
                        .HasColumnName("state")
                        .HasColumnType("varchar")
                        .HasMaxLength(200)
                        .IsRequired();
                    


                    builder.HasOne(p => p.Cabine)
                .WithMany(p => p.Radios)
                .HasForeignKey(p => p.Id_Cabine);

    }
}