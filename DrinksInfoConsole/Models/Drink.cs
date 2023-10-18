using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class Drink
{
    [JsonPropertyName("strDrink")] public string? StrDrink { get; set; }
    [JsonPropertyName("idDrink")] public string? IdDrink { get; set; }

    public Drink(string? strDrink, string? idDrink)
    {
        StrDrink = strDrink;
        IdDrink = idDrink;
    }

    public override string? ToString()
    {
        return StrDrink;
    }
}