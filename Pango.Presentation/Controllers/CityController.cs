using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pango.Application.City.Queries;
using Pango.Presentation.Models.Mappers;

namespace Pango.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CityController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCities(
        [FromServices] IMediator _mediator,
        [FromServices] IApiMapper _mapper)
    {
        var result = await _mediator.Send(new GetCitiesQuery());

        if (result == null || !result.Any())
            return NotFound();

        return Ok(_mapper.Map(result));
    }
}