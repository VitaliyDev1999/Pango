using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pango.API.Models.Request;
using Pango.Application.Parking.Commands;
using Pango.Application.Parking.Queries;
using Pango.Domain.Models;
using Pango.Presentation.Models.Mappers;
using Pango.Presentation.Models.Response;

namespace Pango.Presenatation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParkingController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetParking(
        [FromServices] IMediator _mediator,
        [FromServices] IApiMapper _mapper)
    {
        var result = await _mediator.Send(new GetParkingRecordsQuery());

        if (result == null || !result.Any())
            return NotFound();

        return Ok(_mapper.Map(result));
    }

    [HttpPost]
    public async Task<IActionResult> AddParking(
        [FromServices] IMediator _mediator,
        [FromServices] IApiMapper _mapper,
        [FromBody] CreateParkingRequest request)
    {
        var result = await _mediator.Send(new CreateParkingRecordCommand(new ParkingRecordModel()
        {
            Id = Guid.NewGuid(),
            PhonePlatform = request.PhonePlatform,
            PhoneNumber = request.PhoneNumber,
            CarNumber = request.CarNumber,
            CityId = request.CityId,
            CustomerId = request.CustomerId,
            Lat = request.Lat,
            Long = request.Long,
            ParkingTime = request.ParkingTime,
            ParkingZoneIdss = request.ParkingZoneIdss
        }));

        if (result == null)
            return BadRequest();

        return Ok(_mapper.Map(result));
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateParking(
        [FromServices] IMediator _mediator,
        [FromServices] IApiMapper _mapper,
        [FromBody] UpdateParkingRequest request)
    {
        var result = await _mediator.Send(new UpdateParkingRecordCommand(new ParkingRecordModel()
        {
            Id = request.Id,
            PhonePlatform = request.PhonePlatform,
            PhoneNumber = request.PhoneNumber,
            CarNumber = request.CarNumber,
            CityId = request.CityId,
            CustomerId = request.CustomerId,
            Lat = request.Lat,
            Long = request.Long,
            ParkingTime = request.ParkingTime,
            ParkingZoneIdss = request.ParkingZoneIdss
        }));


        if (result == null)
            return NotFound();

        return Ok(_mapper.Map(result));
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteParking(
        [FromServices] IMediator _mediator,
        [FromRoute] Guid id)
    {
        var result = await _mediator.Send(new DeleteParkingRecordCommand(id));

        if (!result)
            return NotFound();

        return Ok(result);
    }
}
