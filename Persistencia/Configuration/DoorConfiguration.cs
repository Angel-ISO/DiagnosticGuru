using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class DoorConfiguration : IEntityTypeConfiguration<Door>
    {
    public void Configure(EntityTypeBuilder<Door> builder)
    {
        builder.ToTable("doors");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Door")
                .HasColumnType("string")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Fowardleft)
                .HasColumnName("Fowardleft")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Backdoorleft)
                .HasColumnName("Backdoorleft")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Fowardright)
                .HasColumnName("Fowardright")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                 builder.Property(p => p.Backdoorright)
                .HasColumnName("Backdoorright")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                
                 builder.Property(p => p.Trunk)
                .HasColumnName("Trunk")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


                   builder.Property(p => p.Hood)
                .HasColumnName("Hood")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


                  builder.HasOne(p => p.Inspecccion)
                .WithMany(p => p.Doors)
                .HasForeignKey(p => p.Id_Inspeccion);

              
    }
}