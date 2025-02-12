using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class Turf{
    [Key]
    public int TurfId { get; set; }
    public required string  TurfName { get; set; }
    [ForeignKey("TurfLocationId")]
    public City? City_id { get; set; }
    public int TurfLocationId { get; set; }

    public required string ContactNumber { get; set; }
    public bool IsAvailable { get; set; }

    public TimeSpan OpeningTime { get; set; }
    public TimeSpan ClosingTime { get; set; }
    

}