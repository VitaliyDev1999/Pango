using MediatR;
using Pango.Domain.Interfaces;
using Pango.Domain.Entities;
using AutoMapper;


namespace Pango.Application.Parking.Commands;

public class UpdateParkingRecordHandler : IRequestHandler<UpdateParkingRecordCommand, ParkingRecord>
{
    private readonly IParkingRepository _customerRepository;
    private readonly IMapper _mapper;

    public UpdateParkingRecordHandler(IParkingRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<ParkingRecord> Handle(UpdateParkingRecordCommand request, CancellationToken cancellationToken)
    {
        var parking = _mapper.Map<ParkingRecord>(request.ParkingRecord);
        //foreach (var zone in request.ParkingRecord.ParkingZoneIdss)
        //{
        //    parking.ParkingZone.Add(new ParkingZone()
        //    {
        //        Id = zoneId,
        //    });
        //}
        return await _customerRepository.UpdateAsync(parking);
    }
}
