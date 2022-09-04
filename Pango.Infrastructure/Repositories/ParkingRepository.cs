﻿using Microsoft.EntityFrameworkCore;
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
        return parking;
    }

    public async Task<ParkingRecord> UpdateAsync(ParkingRecord parking)
    {
        _dbContext.ParkingRecord.Update(parking);
        await _dbContext.SaveChangesAsync();
        return parking;
    }
}
