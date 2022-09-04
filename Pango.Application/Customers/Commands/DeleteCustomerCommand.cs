using MediatR;

namespace Pango.Application.Customers.Commands;

public record DeleteCustomerCommand(Guid Id) : IRequest<bool>;

