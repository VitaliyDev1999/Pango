using MediatR;
using Pango.Domain.Entities;
using Pango.Domain.Models;

namespace Pango.Application.Customers.Commands;

public record UpdateCustomerCommand(CustomerModel Customer) : IRequest<Customer>;
