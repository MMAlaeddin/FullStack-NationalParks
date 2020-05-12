
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string State { get; set; }
    [StringLength(2000)]
    public string Description { get; set; }
    public int ClimbingRoutes { get; set; }
    public int Campgrounds { get; set; }
    public int GeneralStores { get; set; }
  }
}