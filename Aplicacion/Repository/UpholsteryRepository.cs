using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class UpholsteryRepository : GenericRepository<Upholstery>, IUpholsteryRepository
{
    public UpholsteryRepository(DiagnosticGuruContext context) : base(context)
    {
        
    }
}
