using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Countries
{
    public class Consultation 
    {
        public class ListCountry : IRequest<List<Country>>{}

        public class Manejador : IRequestHandler<ListCountry, List<Country>>
        {
            private readonly DiagnosticGuruContext contex;

            public Manejador(DiagnosticGuruContext _contex){
                contex = _contex;
            }

            public async Task<List<Country>> Handle(ListCountry request, CancellationToken cancellationToken)
            {
                var countries = await contex.Countries.ToListAsync();
                return countries;
            }
        }

    }
}