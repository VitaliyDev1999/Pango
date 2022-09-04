using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pango.API.Models.Request;
using Pango.Application.Customers.Commands;
using Pango.Application.Customers.Queries;
using Pango.Domain.Models;

namespace Pango.Presenatation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetCustomers(
        [FromServices] IMediator _mediator)
    {
        var result = await _mediator.Send(new GetAllCustomersQuery());

        if (result == null || !result.Any())
            return NotFound();

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddCustomers(
        [FromServices] IMediator _mediator,
        [FromBody] CreateCustomerRequest request)
    {
        var result = await _mediator.Send(new CreateCustomerCommand(new CustomerModel()
        {
            Id = Guid.NewGuid(),
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            PhoneNumber = request.PhoneNumber
        }));

        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateCustomers(
        [FromServices] IMediator _mediator,
        [FromBody] UpdateCustomerRequest request)
    {
        var result = await _mediator.Send(new UpdateCustomerCommand(new CustomerModel()
        {
            Id = request.Id,
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            PhoneNumber = request.PhoneNumber
        }));

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteCustomers(
        [FromServices] IMediator _mediator,
        [FromRoute] Guid id)
    {
        var result = await _mediator.Send(new DeleteCustomerCommand(id));

        if (!result)
            return NotFound();

        return Ok(result);
    }
}
