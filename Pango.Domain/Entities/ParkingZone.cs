using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pango.Domain.Entities;

public class ParkingZone
{

    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<ParkingRecord> ParkingRecord { get; set; }
}
