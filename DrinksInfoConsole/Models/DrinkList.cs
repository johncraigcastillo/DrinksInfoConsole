using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class DrinkList
{
    [JsonPropertyName("drinks")] public List<Drink>? Drinks { get; set; }
}