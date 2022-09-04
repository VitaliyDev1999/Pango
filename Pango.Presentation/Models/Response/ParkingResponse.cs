using Pango.Domain.Enum;

namespace Pango.Presentation.Models.Response;

public class ParkingResponse
{
    public Guid Id { get; set; }
    public DateTime ParkingTime { get; set; }
    public string? CarNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public PlatformEnum PhonePlatform { get; set; }
    public string? Lat { get; set; }
    public string? Long { get; set; }

    public CustomerResponse Customer { get; set; }
    public CityResponse City { get; set; }
    public IEnumerable<ParkingZoneResponse> ParkingZones { get; set; }
}
