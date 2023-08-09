using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class RepairOrderConfiguration : IEntityTypeConfiguration<RepairOrder>
    {
    public void Configure(EntityTypeBuilder<RepairOrder> builder)
    {
        builder.ToTable("repairorders");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_RepairOrder")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();


                    builder.HasOne(p => p.DiagnosticMechanic)
                .WithMany(p => p.RepairOrders)
                .HasForeignKey(p => p.Id_DiagnosticMechanic);

                                    builder.HasOne(p => p.OrderService)
                .WithMany(p => p.RepairOrders)
                .HasForeignKey(p => p.Id_OrderService);

    }
}