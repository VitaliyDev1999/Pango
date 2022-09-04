using MediatR;
using Pango.Domain.Interfaces;

namespace Pango.Application.Parking.Commands;

public class DeleteParkingRecordHandler : IRequestHandler<DeleteParkingRecordCommand, bool>
{
    private readonly IParkingRepository _customerRepository;

    public DeleteParkingRecordHandler(IParkingRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<bool> Handle(DeleteParkingRecordCommand request, CancellationToken cancellationToken)
    {
        return await _customerRepository.DeleteAsync(request.Id);
    }
}
