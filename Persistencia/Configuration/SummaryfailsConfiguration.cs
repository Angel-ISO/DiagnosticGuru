using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class SummaryFailsConfiguration : IEntityTypeConfiguration<SummaryFail>
    {
    public void Configure(EntityTypeBuilder<SummaryFail> builder)
    {
        builder.ToTable("summaryfails");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Fails")
                .HasColumnType("string")
                .HasMaxLength(200)
                .IsRequired();

                 builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


                    builder.HasOne(p => p.DiagnosticMechanic)
                .WithMany(p => p.SummaryFails)
                .HasForeignKey(p => p.Id_DiagM);

    }
}