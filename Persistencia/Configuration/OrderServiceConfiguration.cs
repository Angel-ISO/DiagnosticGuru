using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class OrderServiceConfiguration : IEntityTypeConfiguration<OrderService>
    {
    public void Configure(EntityTypeBuilder<OrderService> builder)
    {
        builder.ToTable("orderservices");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_OrderService")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.DelyveryDate)
                .HasColumnName("DelyveryDate")
                .HasColumnType("Date")
                .IsRequired();

            builder.HasOne(p => p.City)
                .WithMany(p => p.OrderServices)
                .HasForeignKey(p => p.Id_City);


                  builder.HasOne(p => p.State)
                .WithMany(p => p.OrderServices)
                .HasForeignKey(p => p.Id_State);
    }
}