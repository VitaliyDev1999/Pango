using Pango.Domain.Enum;

namespace Pango.Presentation.Models.Response;

public class ParkingResponse
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime ParkingTime { get; set; }
    public string? CarNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public PlatformEnum PhonePlatform { get; set; }
    public string? Lat { get; set; }
    public string? Long { get; set; }
    public Guid CityId { get; set; }
    public Guid[] ParkingZoneIdss { get; set; }
}
