using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pango.Presentation.Models.Mappers;

namespace Pango.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParkingZoneController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetParkingZones(
        [FromServices] IMediator _mediator,
        [FromServices] IApiMapper _mapper)
    {
        var result = await _mediator.Send(new GetParkingZonesQuery());

        if (result == null || !result.Any())
            return NotFound();

        return Ok(_mapper.Map(result));
    }
}
