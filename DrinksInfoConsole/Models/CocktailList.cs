using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class CocktailList
{
    [JsonPropertyName("drinks")] public List<Cocktail>? Drinks { get; set; }
}