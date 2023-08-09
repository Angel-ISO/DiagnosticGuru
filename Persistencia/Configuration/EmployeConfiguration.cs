using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class EmployeConfiguration : IEntityTypeConfiguration<Employe>
    {
    public void Configure(EntityTypeBuilder<Employe> builder)
    {
        builder.ToTable("employe");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_employe")
                .HasColumnType("int")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.HasOne(p => p.Person)
                .WithMany(p => p.Employes)
                .HasForeignKey(p => p.Id_PE);


                  builder.HasOne(p => p.RolEmploye)
                .WithMany(p => p.Employes)
                .HasForeignKey(p => p.Id);

                  builder.HasOne(p => p.DiagnosticMechanic)
                .WithMany(p => p.Employes)
                .HasForeignKey(p => p.Id);

                
                  builder.HasOne(p => p.Speciality)
                .WithMany(p => p.Employes)
                .HasForeignKey(p => p.Id_Speciality);

                
                  builder.HasOne(p => p.Arl)
                .WithMany(p => p.Employes)
                .HasForeignKey(p => p.Id_Arl);


                  builder.HasOne(p => p.Eps)
                .WithMany(p => p.Employes)
                .HasForeignKey(p => p.Id_Eps);
                

    }
}