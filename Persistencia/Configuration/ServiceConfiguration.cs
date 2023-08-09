using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.ToTable("services");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Service")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();


                builder.Property(p => p.TotalValue)
                .HasColumnName("totalvalue")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


                    builder.HasOne(p => p.ServiceFee)
                .WithMany(p => p.Services)
                .HasForeignKey(p => p.Id_ServiceFee);

    }
}