using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class DiagnosticMechanicConfiguration : IEntityTypeConfiguration<DiagnosticMechanic>
    {
    public void Configure(EntityTypeBuilder<DiagnosticMechanic> builder)
    {
        builder.ToTable("diagnosticmechanic");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_DiagMechanic")
                .HasColumnType("string")
                .HasMaxLength(200)
                .IsRequired();

    }
}