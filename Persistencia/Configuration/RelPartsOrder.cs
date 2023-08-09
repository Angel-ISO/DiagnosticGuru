using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class RelPartsOrderConfiguration : IEntityTypeConfiguration<RelPartsOrder>
    {
    public void Configure(EntityTypeBuilder<RelPartsOrder> builder)
    {
        builder.ToTable("relpartsorder");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Relserviceorder")
                .HasColumnType("int")
                .IsRequired();

                    builder.HasOne(p => p.RepairOrder)
                .WithMany(p => p.RelPartsOrders)
                .HasForeignKey(p => p.Id_RepairOrder);

                 builder.HasOne(p => p.SquarePart)
                .WithMany(p => p.RelPartsOrders)
                .HasForeignKey(p => p.Id_SquareParts);

    }
}