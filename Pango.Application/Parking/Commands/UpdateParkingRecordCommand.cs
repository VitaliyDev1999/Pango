using MediatR;
using Pango.Domain.Entities;
using Pango.Domain.Models;

namespace Pango.Application.Parking.Commands;

public record UpdateParkingRecordCommand(ParkingRecordModel ParkingRecord) : IRequest<ParkingRecord>;
