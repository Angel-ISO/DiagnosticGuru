using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Paises
{
    public class Consultas 
    {
        public class ListaCountry : IRequest<List<Country>>{}

        public class Manejador : IRequestHandler<ListaCountry, List<Country>>
        {
            private readonly DiagnosticGuruContext contex;

            public Manejador(DiagnosticGuruContext _contex){
                contex = _contex;
            }

            public async Task<List<Country>> Handle(ListaCountry request, CancellationToken cancellationToken)
            {
                var paises = await contex.Countries.ToListAsync();
                return paises;
            }
        }

    }
}