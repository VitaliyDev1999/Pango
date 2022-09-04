using MediatR;
using Pango.Application.ParkingZone.Queries;
using Pango.Domain.Interfaces;

namespace Pango.Application.City.Queries;

public class GetCitiesHandler : IRequestHandler<GetCitiesQuery, IEnumerable<Pango.Domain.Entities.City>>
{
    private readonly ICityRepository _cityRepository;

    public GetCitiesHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    async Task<IEnumerable<Pango.Domain.Entities.City>> IRequestHandler<GetCitiesQuery, IEnumerable<Domain.Entities.City>>.Handle(GetCitiesQuery request, CancellationToken cancellationToken)
    {
        return await _cityRepository.GetAllCitiesAsync();
    }
}
