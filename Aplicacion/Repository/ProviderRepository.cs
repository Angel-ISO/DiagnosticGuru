using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class ProviderRepository : GenericRepository<Provider>, IProviderRepository
{
    public ProviderRepository(DiagnosticGuruContext context) : base(context)
    {
        
    }
}