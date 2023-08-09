using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class UpholsteryConfiguration : IEntityTypeConfiguration<Upholstery>
    {
    public void Configure(EntityTypeBuilder<Upholstery> builder)
    {
        builder.ToTable("upholstery");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_upholstery")
                .HasColumnType("int")
                .IsRequired();

                  builder.Property(p => p.Ceiling)
                .HasColumnName("ceiling")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.Property(p => p.Carpet)
                        .HasColumnName("carpet")
                        .HasColumnType("varchar")
                        .HasMaxLength(200)
                        .IsRequired();

                     builder.Property(p => p.Seating)
                        .HasColumnName("seating")
                        .HasColumnType("varchar")
                        .HasMaxLength(200)
                        .IsRequired();

                        builder.Property(p => p.Others)
                        .HasColumnName("others")
                        .HasColumnType("varchar")
                        .HasMaxLength(200)
                        .IsRequired();

                    builder.HasOne(p => p.Cabine)
                .WithMany(p => p.Upholsteries)
                .HasForeignKey(p => p.Id_Cabine);

    }
}