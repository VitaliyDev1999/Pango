using Microsoft.EntityFrameworkCore;
using Pango.Domain.Interfaces;
using Pango.Domain.Entities;

namespace Pango.Infrastructure.Repositories;

public class ParkingRepository : IParkingRepository
{
    private readonly PangoContext _dbContext;

    public ParkingRepository(PangoContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<ParkingRecord>> GetAllParkingRecordsAsync()
    {
        return await _dbContext.ParkingRecord
            .Include(x => x.ParkingZone)
            .Include(x => x.City)
            .Include(x => x.Customer)
            .ToArrayAsync();
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var parking = await _dbContext.ParkingRecord.FirstAsync(x => x.Id == id);
        if (parking == null)
            return false;

        _dbContext.ParkingRecord.Remove(parking);
        await _dbContext.SaveChangesAsync();
        return true;    
    }

    public async Task<ParkingRecord> CreateAsync(ParkingRecord parking)
    {
        _dbContext.ParkingRecord.Add(parking);
        await _dbContext.SaveChangesAsync();
        return await _dbContext.ParkingRecord
            .Include(x => x.ParkingZone)
            .Include(x => x.City)
            .Include(x => x.Customer).FirstAsync(x => x.Id == parking.Id);
    }

    public async Task<ParkingRecord> UpdateAsync(ParkingRecord parking)
    {
        _dbContext.ParkingRecord.Update(parking);
        await _dbContext.SaveChangesAsync();
        return await _dbContext.ParkingRecord
            .Include(x => x.ParkingZone)
            .Include(x => x.City)
            .Include(x => x.Customer).FirstAsync(x => x.Id == parking.Id);
    }
}
