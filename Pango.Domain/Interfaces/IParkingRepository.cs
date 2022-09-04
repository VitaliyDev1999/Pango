using Pango.Domain.Entities;

namespace Pango.Domain.Interfaces;

public interface IParkingRepository
{
    public Task<IEnumerable<ParkingRecord>> GetAllParkingRecordsAsync();

    public Task<ParkingRecord> CreateAsync(ParkingRecord parking);

    public Task<ParkingRecord> UpdateAsync(ParkingRecord parking);

    public Task<bool> DeleteAsync(Guid id);
}
