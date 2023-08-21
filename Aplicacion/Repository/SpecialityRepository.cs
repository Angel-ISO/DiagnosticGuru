using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;
public class SpecialityRepository : GenericRepository<Speciality>, ISpecialityRepository
{
    public SpecialityRepository(DiagnosticGuruContext context) : base(context)
    {
        
    }
}