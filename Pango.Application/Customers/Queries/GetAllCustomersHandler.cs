using MediatR;
using Pango.Domain.Interfaces;
using Pango.Domain.Entities;

namespace Pango.Application.Customers.Queries;

public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, IEnumerable<Customer>>
{
    private readonly ICustomerRepository _customerRepository;

    public GetAllCustomersHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    async Task<IEnumerable<Customer>> IRequestHandler<GetAllCustomersQuery, IEnumerable<Customer>>.Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
    {
        return await _customerRepository.GetAllCustomersAsync();
    }
}