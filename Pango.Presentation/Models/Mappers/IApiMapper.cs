using Pango.Domain.Entities;
using Pango.Presentation.Models.Response;

namespace Pango.Presentation.Models.Mappers;

public interface IApiMapper
{
    List<ParkingResponse> Map(IEnumerable<ParkingRecord> list);

    List<CustomerResponse> Map(IEnumerable<Customer> list);

    List<ParkingZoneResponse> Map(IEnumerable<ParkingZone> list);

    List<CityResponse> Map(IEnumerable<City> list);

    ParkingResponse Map(ParkingRecord parking);

    CustomerResponse Map(Customer customer);
}
