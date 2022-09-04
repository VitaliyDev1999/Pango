using MediatR;
using Pango.Domain.Interfaces;
using Pango.Domain.Entities;

namespace Pango.Application.Parking.Queries;

public class GetParkingRecordsHandler : IRequestHandler<GetParkingRecordsQuery, IEnumerable<ParkingRecord>>
{
    private readonly IParkingRepository _parkingRepository;

    public GetParkingRecordsHandler(IParkingRepository parkingRepository)
    {
        _parkingRepository = parkingRepository;
    }

    async Task<IEnumerable<ParkingRecord>> IRequestHandler<GetParkingRecordsQuery, IEnumerable<ParkingRecord>>.Handle(GetParkingRecordsQuery request, CancellationToken cancellationToken)
    {
        return await _parkingRepository.GetAllParkingRecordsAsync();
    }
}