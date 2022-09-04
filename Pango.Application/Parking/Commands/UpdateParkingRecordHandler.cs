using MediatR;
using Pango.Domain.Interfaces;
using Pango.Domain.Entities;
using AutoMapper;


namespace Pango.Application.Parking.Commands;

public class UpdateParkingRecordHandler : IRequestHandler<UpdateParkingRecordCommand, ParkingRecord>
{
    private readonly IParkingRepository _customerRepository;
    private readonly IParkingZoneRepository _parkingZoneRepository;
    private readonly IMapper _mapper;

    public UpdateParkingRecordHandler(IParkingRepository customerRepository, IParkingZoneRepository parkingZoneRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _parkingZoneRepository = parkingZoneRepository;
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<ParkingRecord> Handle(UpdateParkingRecordCommand request, CancellationToken cancellationToken)
    {
        var parking = _mapper.Map<ParkingRecord>(request.ParkingRecord);
        var parkingZones = (await _parkingZoneRepository.GetAllParkingZonesAsync()).Where(x => request.ParkingRecord.ParkingZoneIdss.ToList().Contains(x.Id)).ToList();
        parking.ParkingZone = parkingZones;
        return await _customerRepository.UpdateAsync(parking);
    }
}
