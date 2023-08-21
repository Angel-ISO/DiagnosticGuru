using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class ServiceRepository : GenericRepository<Service>, IServiceRepository
{
    public ServiceRepository(DiagnosticGuruContext context) : base(context)
    {
        
    }
}