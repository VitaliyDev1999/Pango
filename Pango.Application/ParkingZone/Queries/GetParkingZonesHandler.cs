using MediatR;
using Pango.Domain.Interfaces;

namespace Pango.Application.ParkingZone.Queries;

public class GetParkingZonesHandler : IRequestHandler<GetParkingZonesQuery, IEnumerable<Pango.Domain.Entities.ParkingZone>>
{
    private readonly IParkingZoneRepository _parkingZoneRepository;

    public GetParkingZonesHandler(IParkingZoneRepository parkingZoneRepository)
    {
        _parkingZoneRepository = parkingZoneRepository;
    }

    async Task<IEnumerable<Pango.Domain.Entities.ParkingZone>> IRequestHandler<GetParkingZonesQuery, IEnumerable<Pango.Domain.Entities.ParkingZone>>.Handle(GetParkingZonesQuery request, CancellationToken cancellationToken)
    {
        return await _parkingZoneRepository.GetAllParkingZonesAsync();
    }
}
