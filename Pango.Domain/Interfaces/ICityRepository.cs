using Pango.Domain.Entities;

namespace Pango.Domain.Interfaces;

public interface ICityRepository
{
    Task<IEnumerable<City>> GetAllCitiesAsync();
}
