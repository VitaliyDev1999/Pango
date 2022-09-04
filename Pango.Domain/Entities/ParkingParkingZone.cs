//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Pango.Domain.Entities;

//public class ParkingParkingZone
//{
//    [Required]
//    [Key]
//    public Guid Id { get; set; }

//    public Guid ParkingZoneId { get; set; }

//    public Guid ParkingId { get; set; }

//    [ForeignKey("ParkingZoneId")]
//    [InverseProperty("ParkingParkingZone")]
//    public ParkingZone ParkingZone { get; set; }

//    [ForeignKey("ParkingId")]
//    [InverseProperty("ParkingParkingZone")]
//    public ParkingRecord ParkingRecord { get; set; }
//}
