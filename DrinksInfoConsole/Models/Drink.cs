using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class Drink
{
    [JsonPropertyName("strDrink")] public string? StrDrink { get; set; }
    [JsonPropertyName("idDrink")] public string? IdDrink { get; set; }
    [JsonPropertyName("strAlcoholic")] public string? StrAlcoholic { get; set; }
    [JsonPropertyName("strGlass")] public string? StrGlass { get; set; }
    [JsonPropertyName("strInstructions")] public string? StrInstructions { get; set; }
    public List<string>? IngredientList { get; set; }
    [JsonPropertyName("strIngredient1")] public string? StrIngredient1 { get; set; }
    [JsonPropertyName("strIngredient2")] public string? StrIngredient2 { get; set; }
    [JsonPropertyName("strIngredient3")] public string? StrIngredient3 { get; set; }
    [JsonPropertyName("strIngredient4")] public string? StrIngredient4 { get; set; }
    [JsonPropertyName("strIngredient5")] public string? StrIngredient5 { get; set; }
    [JsonPropertyName("strIngredient6")] public string? StrIngredient6 { get; set; }
    [JsonPropertyName("strIngredient7")] public string? StrIngredient7 { get; set; }
    [JsonPropertyName("strIngredient8")] public string? StrIngredient8 { get; set; }
    [JsonPropertyName("strIngredient9")] public string? StrIngredient9 { get; set; }
    [JsonPropertyName("strIngredient10")] public string? StrIngredient10 { get; set; }
    [JsonPropertyName("strIngredient11")] public string? StrIngredient11 { get; set; }
    [JsonPropertyName("strIngredient12")] public string? StrIngredient12 { get; set; }
    [JsonPropertyName("strIngredient13")] public string? StrIngredient13 { get; set; }
    [JsonPropertyName("strIngredient14")] public string? StrIngredient14 { get; set; }
    [JsonPropertyName("strIngredient15")] public string? StrIngredient15 { get; set; }

    public Drink(string? strDrink, string? idDrink, string? strAlcoholic, string? strGlass, string? strInstructions,
        string? strIngredient1, string? strIngredient2, string? strIngredient3, string? strIngredient4,
        string? strIngredient5, string? strIngredient6, string? strIngredient7, string? strIngredient8,
        string? strIngredient9, string? strIngredient10, string? strIngredient11, string? strIngredient12,
        string? strIngredient13, string? strIngredient14, string? strIngredient15)
    {
        StrDrink = strDrink;
        IdDrink = idDrink;
        StrAlcoholic = strAlcoholic;
        StrGlass = strGlass;
        StrInstructions = strInstructions;
        StrIngredient1 = strIngredient1;
        StrIngredient2 = strIngredient2;
        StrIngredient3 = strIngredient3;
        StrIngredient4 = strIngredient4;
        StrIngredient5 = strIngredient5;
        StrIngredient6 = strIngredient6;
        StrIngredient7 = strIngredient7;
        StrIngredient8 = strIngredient8;
        StrIngredient9 = strIngredient9;
        StrIngredient10 = strIngredient10;
        StrIngredient11 = strIngredient11;
        StrIngredient12 = strIngredient12;
        StrIngredient13 = strIngredient13;
        StrIngredient14 = strIngredient14;
        StrIngredient15 = strIngredient15;
        IngredientList = PopulateInstructionsList(this);
    }


    private List<string> PopulateInstructionsList(Drink drink)
    {
        var instructionsList = new List<string>();
        var drinkType = drink.GetType();

        for (int i = 1; i <= 15; i++)
        {
            var ingredientProperty = drinkType.GetProperty($"StrIngredient{i}");
            if (ingredientProperty != null)
            {
                var ingredientValue = ingredientProperty.GetValue(drink) as string;
                if (!string.IsNullOrEmpty(ingredientValue))
                {
                    instructionsList.Add(ingredientValue);
                }
            }
        }

        return instructionsList;
    }


    public override string? ToString()
    {
        return StrDrink;
    }
}