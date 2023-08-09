using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class RolEmployeConfiguration : IEntityTypeConfiguration<RolEmploye>
    {
    public void Configure(EntityTypeBuilder<RolEmploye> builder)
    {
        builder.ToTable("rolemployes");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_RolEmploye")
                .HasColumnType("string")
                .HasMaxLength(200)
                .IsRequired();

            

         builder.HasOne(p => p.Rol)
                .WithMany(p => p.RolEmployes)
                .HasForeignKey(p => p.Id_Employe);
                
    
    }
}