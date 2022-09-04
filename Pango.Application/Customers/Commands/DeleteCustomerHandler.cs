using MediatR;
using Pango.Domain.Interfaces;

namespace Pango.Application.Customers.Commands;

public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, bool>
{
    private readonly ICustomerRepository _customerRepository;

    public DeleteCustomerHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        return await _customerRepository.DeleteAsync(request.Id);
    }
}
