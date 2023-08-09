using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class ProvderConfiguration : IEntityTypeConfiguration<Provider>
    {
    public void Configure(EntityTypeBuilder<Provider> builder)
    {
        builder.ToTable("providers");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Provider")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();

            

        builder.Property(p => p.NameCompany)
                .HasColumnName("NameCompany")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

    }
}