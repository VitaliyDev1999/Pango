using MediatR;

namespace Pango.Application.City.Queries;

public record GetCitiesQuery() : IRequest<IEnumerable<Pango.Domain.Entities.City>>;
