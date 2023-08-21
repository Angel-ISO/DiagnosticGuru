using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class RolEmployeRepository : GenericRepository<RolEmploye>, IRolEmployeRepository
{
    public RolEmployeRepository(DiagnosticGuruContext context) : base(context)
    {
        
    }
}