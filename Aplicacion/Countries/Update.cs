using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Aplicacion.Countries
{
    public class Update
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
            public string NewNameCountry { get; set; }
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

                country.NameCountry = request.NewNameCountry;

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
