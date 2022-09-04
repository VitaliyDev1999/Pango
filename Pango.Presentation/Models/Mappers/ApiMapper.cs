using Pango.Domain.Entities;
using Pango.Presentation.Models.Response;

namespace Pango.Presentation.Models.Mappers;

public class ApiMapper : IApiMapper
{
    public List<ParkingResponse> Map(IEnumerable<ParkingRecord> list)
    {
        return list.Select(x => Map(x)).ToList();
    }

    public ParkingResponse Map(ParkingRecord parking)
    {
        return new ParkingResponse()
        {
            CarNumber = parking.CarNumber,
            City = Map(parking.City),
            Customer = Map(parking.Customer),
            Id = parking.Id,
            Lat = parking.Lat,
            Long = parking.Long,
            ParkingTime = parking.ParkingTime,
            PhoneNumber = parking.PhoneNumber,
            PhonePlatform = parking.PhonePlatform,
            ParkingZones = Map(parking.ParkingZone)
        };
    }

    public List<CustomerResponse> Map(IEnumerable<Customer> list)
    {
        return list.Select(x => Map(x)).ToList();
    }

    public CustomerResponse Map(Customer customer)
    {
        return new CustomerResponse()
        {
            Id = customer.Id,
            Email = customer.Email,
            PhoneNumber = customer.PhoneNumber,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
        };
    }

    public List<ParkingZoneResponse> Map(IEnumerable<ParkingZone> list)
    {
        return list.Select(x => Map(x)).ToList();
    }

    public ParkingZoneResponse Map(ParkingZone parkingZone)
    {
        return new ParkingZoneResponse()
        {
            Id = parkingZone.Id,
            Name = parkingZone.Name
        };
    }

    public List<CityResponse> Map(IEnumerable<City> list)
    {
        return list.Select(x => Map(x)).ToList();
    }

    public CityResponse Map(City city)
    {
        return new CityResponse()
        {
            Id = city.Id,
            Name = city.Name
        };
    }
}
