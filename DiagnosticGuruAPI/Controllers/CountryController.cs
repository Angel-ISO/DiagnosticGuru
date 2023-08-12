using Aplicacion.Countries;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DiagnosticGuruApi.Controllers;
public class CountriesController : BaseApiController
{
    private readonly IMediator mediator;

    public CountriesController(IMediator _mediator){
        mediator = _mediator;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<Country>>> Get()
    {
        return await mediator.Send(new Consultation.ListCountry());
    }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] Creation.Command command)
        {
            await mediator.Send(command);
            return StatusCode(StatusCodes.Status201Created);
        }

        
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(int id, [FromBody] Update.Command command)
        {
            command.Id = id;
            await mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            await mediator.Send(new Deletion.Command { Id = id });
            return NoContent();
        }
}