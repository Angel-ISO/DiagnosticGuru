using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.ToTable("vehicle");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Vehicle")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.CodPlate)
                .HasColumnName("codplate")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                
            builder.Property(p => p.Model)
                .HasColumnName("Model")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                 builder.Property(p => p.YearModel)
                .HasColumnName("yearModel")
                .HasColumnType("date")
                .IsRequired();


                  builder.HasOne(p => p.Person)
                .WithMany(p => p.Vehicles)
                .HasForeignKey(p => p.Id_Person);

              
    }
}