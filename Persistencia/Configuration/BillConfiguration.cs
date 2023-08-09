using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.ToTable("bills");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Bill")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();

                 builder.Property(p => p.TotalCostParts)
                .HasColumnName("TotalCostParts")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
                
                 builder.Property(p => p.TotalService)
                .HasColumnName("TotalService")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


                 builder.Property(p => p.Total)
                .HasColumnName("total")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


                    builder.HasOne(p => p.RepairOrder)
                .WithMany(p => p.Bills)
                .HasForeignKey(p => p.Id_RepairOrder);

    }
}