using Pango.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pango.Domain.Entities;

public class ParkingRecord
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public Guid CustomerId { get; set; }
    [Required]
    public DateTime ParkingTime { get; set; }
    [Required]
    public string? CarNumber { get; set; }
    [Required]
    public string? PhoneNumber { get; set; }
    [Required]
    public PlatformEnum PhonePlatform { get; set; }
    [Required]
    public string? Lat { get; set; }
    [Required]
    public string? Long { get; set; }
    [Required]
    public Guid CityId { get; set; }

    [ForeignKey("CityId")]
    public City City { get; set; }

    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }

    public ICollection<ParkingZone> ParkingZone { get; set; }
}
