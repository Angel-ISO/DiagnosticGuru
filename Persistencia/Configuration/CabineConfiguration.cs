using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class CabineConfiguration : IEntityTypeConfiguration<Cabine>
    {
    public void Configure(EntityTypeBuilder<Cabine> builder)
    {
        builder.ToTable("cabine");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_cabine")
                .HasColumnType("int")
                .IsRequired();

              


                    builder.HasOne(p => p.Inspeccion)
                .WithMany(p => p.Cabines)
                .HasForeignKey(p => p.Id_Inspeccion);

    }
}