using System.ComponentModel.DataAnnotations;

namespace Pango.Domain.Entities;

public class Customer
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
}
