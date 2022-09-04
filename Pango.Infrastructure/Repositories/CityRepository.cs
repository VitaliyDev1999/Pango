using Microsoft.EntityFrameworkCore;
using Pango.Domain.Entities;
using Pango.Domain.Interfaces;

namespace Pango.Infrastructure.Repositories;

public class CityRepository : ICityRepository
{
    private readonly PangoContext _dbContext;

    public CityRepository(PangoContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<City>> GetAllCitiesAsync()
    {
        return await _dbContext.City
            .ToArrayAsync();
    }
}
