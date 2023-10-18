using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class Drink
{
    [JsonPropertyName("strDrink")] public string? StrDrink { get; set; }
    [JsonPropertyName("idDrink")] public string? IdDrink { get; set; }
    [JsonPropertyName("strIngredient1")] public string? StrIngredient1 { get; set; }
    [JsonPropertyName("strAlcoholic")] public string? StrAlcoholic { get; set; }
    [JsonPropertyName("strGlass")] public string? StrGlass { get; set; }
    [JsonPropertyName("strInstructions")] public string? StrInstructions { get; set; }

    public Drink(string? strDrink, string? idDrink, string? strAlcoholic, string? strGlass, string? strInstructions, string? strIngredient1)
    {
        StrDrink = strDrink;
        IdDrink = idDrink;
        StrAlcoholic = strAlcoholic;
        StrGlass = strGlass;
        StrInstructions = strInstructions;
        StrIngredient1 = strIngredient1;
    }

    public override string? ToString()
    {
        return StrDrink;
    }
}