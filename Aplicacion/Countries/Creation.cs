using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Dominio;
using Persistencia;

namespace Aplicacion.Countries
{
    public class Creation
    {
        public class Command : IRequest
        {
            public string NameCountry { get; set; }
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
                var country = new Country
                {
                    NameCountry = request.NameCountry,
                };

                _context.Countries.Add(country);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
