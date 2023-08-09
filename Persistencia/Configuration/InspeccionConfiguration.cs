using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class InspeccionConfiguration : IEntityTypeConfiguration<Inspeccion>
    {
    public void Configure(EntityTypeBuilder<Inspeccion> builder)
    {
        builder.ToTable("inspeccion");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Inspeccion")
                .HasColumnType("string")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.DateOfEntry)
                .HasColumnName("DateofEntry")
                .HasColumnType("date")
                .IsRequired();

                
            builder.Property(p => p.DiagCustomer)
                .HasColumnName("Diagnosticustomer")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


                  builder.HasOne(p => p.Vehicle)
                .WithMany(p => p.Inspeccions)
                .HasForeignKey(p => p.Id_Vehicle);

              
    }
}