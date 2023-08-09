using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Persons");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Cc_Person")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NamePerson)
                .HasColumnName("NamePerson")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                
            builder.Property(p => p.LastNamePerson)
                .HasColumnName("LastNamePerson")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.HasOne(p => p.TypePerson)
                .WithMany(p => p.Persons)
                .HasForeignKey(p => p.Id_TypePerson);

                  builder.HasOne(p => p.Contact)
                .WithMany(p => p.Persons)
                .HasForeignKey(p => p.Id_Contact);
    }
}