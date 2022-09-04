using MediatR;
using Pango.Domain.Entities;
using Pango.Domain.Models;

namespace Pango.Application.Parking.Commands;

public record CreateParkingRecordCommand(ParkingRecordModel ParkingRecord) : IRequest<ParkingRecord>;

