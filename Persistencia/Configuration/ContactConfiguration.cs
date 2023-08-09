using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("contactconfiguration");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_contconfig")
                .HasColumnType("int")
                .IsRequired();

           
                  builder.HasOne(p => p.TypeContact)
                .WithMany(p => p.Contacts)
                .HasForeignKey(p => p.Id_TypeContact);
    }
}