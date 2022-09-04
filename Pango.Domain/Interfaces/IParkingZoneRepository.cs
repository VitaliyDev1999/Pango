using Pango.Domain.Entities;

namespace Pango.Domain.Interfaces;

public interface IParkingZoneRepository
{
    public Task<IEnumerable<ParkingZone>> GetAllParkingZonesAsync();
}
