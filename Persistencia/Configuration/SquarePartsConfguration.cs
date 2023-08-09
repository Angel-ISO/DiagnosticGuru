using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class SquarePartsConfiguration : IEntityTypeConfiguration<SquarePart>
    {
    public void Configure(EntityTypeBuilder<SquarePart> builder)
    {
        builder.ToTable("squareparts");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_SquareParts")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();

            

        builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


        builder.Property(p => p.Price)
                .HasColumnName("Price")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


        builder.Property(p => p.Brand)
                .HasColumnName("Brand")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                 builder.HasOne(p => p.Provider)
                .WithMany(p => p.SquareParts)
                .HasForeignKey(p => p.Id_Nit);

    }
}