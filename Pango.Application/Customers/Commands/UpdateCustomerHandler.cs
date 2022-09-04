using MediatR;
using Pango.Domain.Interfaces;
using Pango.Domain.Entities;
using AutoMapper;

namespace Pango.Application.Customers.Commands;

public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, Customer>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public UpdateCustomerHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = _mapper.Map<Customer>(request.Customer);
        return await _customerRepository.UpdateAsync(customer);
    }
}
