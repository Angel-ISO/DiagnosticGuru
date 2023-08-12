using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Aplicacion.Countries
{
    public class Deletion
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DiagnosticGuruContext _context;

            public Handler(DiagnosticGuruContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var country = await _context.Countries.FindAsync(request.Id);

                if (country == null)
                {
                    throw new Exception($"País con ID {request.Id} no encontrado.");
                }

                _context.Countries.Remove(country);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
