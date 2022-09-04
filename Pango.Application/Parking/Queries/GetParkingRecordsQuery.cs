using MediatR;
using Pango.Domain.Entities;

namespace Pango.Application.Parking.Queries;

public record GetParkingRecordsQuery() : IRequest<IEnumerable<ParkingRecord>>;
