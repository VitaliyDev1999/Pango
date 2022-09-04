using MediatR;

namespace Pango.Application.ParkingZone.Queries;

public record GetParkingZonesQuery() : IRequest<IEnumerable<Pango.Domain.Entities.ParkingZone>>;
