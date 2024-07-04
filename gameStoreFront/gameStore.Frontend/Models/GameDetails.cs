using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using gameStore.Frontend.Converters;

namespace gameStore.Frontend.Models;

public class GameDetails
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Please select a genre")]
    [JsonConverter(typeof(StringConverter))]
    public string? GenreID { get; set; }
    [Range(1, 100)] 
    public decimal Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
}
