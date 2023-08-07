using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;
public class DiagnosticGuruContext : DbContext
{
    public DiagnosticGuruContext(DbContextOptions<DiagnosticGuruContext> options) : base(options)
    {
        
    }
      
 

      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          


          
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
     
     }


