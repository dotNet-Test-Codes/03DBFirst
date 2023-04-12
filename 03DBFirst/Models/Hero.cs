using System.ComponentModel.DataAnnotations;

namespace _03DBFirst.Models;

public partial class Hero
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
