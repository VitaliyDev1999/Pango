using MediatR;


namespace Pango.Application.Parking.Commands;

public record DeleteParkingRecordCommand(Guid Id) : IRequest<bool>;
