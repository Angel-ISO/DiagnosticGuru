using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class ServiceFeeConfiguration : IEntityTypeConfiguration<ServiceFee>
    {
    public void Configure(EntityTypeBuilder<ServiceFee> builder)
    {
        builder.ToTable("servicefee");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_ServiceFee")
                .HasColumnType("int")
                .IsRequired();

            
            builder.Property(p => p.FeePorcent)
                .HasColumnName("Fee_Porcent")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
    }
}