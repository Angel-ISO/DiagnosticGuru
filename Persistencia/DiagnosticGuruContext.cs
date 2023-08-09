using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;
public class DiagnosticGuruContext : DbContext
{
    public DiagnosticGuruContext(DbContextOptions<DiagnosticGuruContext> options) : base(options)
    {
        
    }
       public DbSet<Address> ?Addresses { get; set; }
       public DbSet<Arl> ?Arls { get; set; }
       public DbSet<Bill> ?Bills { get; set; }
       public DbSet<Brand> ?Brands { get; set; }
       public DbSet<Cabine> ?Cabines { get; set; }
       public DbSet<City> ?Cities { get; set; }
       public DbSet<Contact> ?Contacts { get; set; }
       public DbSet<Country> ?Countries { get; set; }
       public DbSet<DiagnosticMechanic> ?DiagnosticMechanics { get; set; }
       public DbSet<Door> ?Doors { get; set; }
       public DbSet<Employe> ?Employes { get; set; }
       public DbSet<Eps> ?Epss { get; set; }
       public DbSet<Inspeccion> ?Inspeccions { get; set; }
       public DbSet<Provider> ?Providers { get; set; }
       public DbSet<OrderService> ?OrderServices { get; set; }
       public DbSet<Person> ?Persons { get; set; }
       public DbSet<Radio> ?Radios { get; set; }
       public DbSet<Region> ?Regions { get; set; }
       public DbSet<RelPartsOrder> ?RelPartsOrders { get; set; }
       public DbSet<RelServiceOrder> ?RelServiceOrders { get; set; }
       public DbSet<RepairOrder> ?RepairOrders { get; set; }
       public DbSet<Rol> ?Rols { get; set; }
       public DbSet<RolEmploye> ?RolEmployes { get; set; }
       public DbSet<Service> ?Services { get; set; }
       public DbSet<ServiceFee> ?ServicesFees { get; set; }
       public DbSet<Speciality> ?Specialities { get; set; }
       public DbSet<SquarePart> ?SquareParts { get; set; }
       public DbSet<State> ?States { get; set; }
       public DbSet<SummaryFail> ?SummaryFails { get; set; }
       public DbSet<Telephone> ?Telephones { get; set; }
       public DbSet<TypeContact> ?TypeContacts { get; set; }
       public DbSet<TypePerson> ?TypePersons { get; set; }
       public DbSet<Upholstery> ?Upholsteries { get; set; }
       public DbSet<Vehicle> ?Vehicles { get; set; }
       
     

      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          


          
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
     
     }


