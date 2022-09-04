using MediatR;
using Pango.Domain.Entities;

namespace Pango.Application.Customers.Queries;

public record GetAllCustomersQuery() : IRequest<IEnumerable<Customer>>;
