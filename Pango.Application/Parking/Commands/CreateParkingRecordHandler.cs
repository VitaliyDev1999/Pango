using MediatR;
using Pango.Domain.Interfaces;
using Pango.Domain.Entities;
using AutoMapper;
using System.Linq;

namespace Pango.Application.Parking.Commands;

public class CreateParkingRecordHandler : IRequestHandler<CreateParkingRecordCommand, ParkingRecord>
{
    private readonly IParkingRepository _customerRepository;
    private readonly IParkingZoneRepository _parkingZoneRepository;
    private readonly IMapper _mapper;

    public CreateParkingRecordHandler(IParkingRepository customerRepository, IParkingZoneRepository parkingZoneRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _parkingZoneRepository = parkingZoneRepository;
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<ParkingRecord> Handle(CreateParkingRecordCommand request, CancellationToken cancellationToken)
    {
        var parking = _mapper.Map<ParkingRecord>(request.ParkingRecord);
        var parkingZones = (await _parkingZoneRepository.GetAllParkingZonesAsync()).Where(x => request.ParkingRecord.ParkingZoneIdss.ToList().Contains(x.Id)).ToList();
        parking.ParkingZone = parkingZones;
        return await _customerRepository.CreateAsync(parking);
    }
}

