using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class Cocktail
{
    [JsonPropertyName("strDrink")] public string? StrDrink { get; set; }

    public Cocktail(string? strDrink)
    {
        StrDrink = strDrink;
    }
}