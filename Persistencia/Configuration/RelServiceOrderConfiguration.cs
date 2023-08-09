using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class RelServiceOrderConfiguration : IEntityTypeConfiguration<RelServiceOrder>
    {
    public void Configure(EntityTypeBuilder<RelServiceOrder> builder)
    {
        builder.ToTable("relserviceorder");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Relserviceorder")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();

                    builder.HasOne(p => p.RepairOrder)
                .WithMany(p => p.RelServiceOrders)
                .HasForeignKey(p => p.Id_RepairOrder);

                 builder.HasOne(p => p.Service)
                .WithMany(p => p.RelServiceOrders)
                .HasForeignKey(p => p.Id_Service);

    }
}