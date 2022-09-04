using System.ComponentModel.DataAnnotations;

namespace Pango.Domain.Entities;

public class City
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }
}
