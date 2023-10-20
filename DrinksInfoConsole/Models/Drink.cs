using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class Drink
{
    [JsonPropertyName("strDrink")] public string? StrDrink { get; set; }
    [JsonPropertyName("idDrink")] public string? IdDrink { get; set; }
    [JsonPropertyName("strAlcoholic")] public string? StrAlcoholic { get; set; }
    [JsonPropertyName("strGlass")] public string? StrGlass { get; set; }
    [JsonPropertyName("strInstructions")] public string? StrInstructions { get; set; }
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
    public List<string>? IngredientList { get; set; }
    [JsonPropertyName("strMeasure1")] public string? StrMeasure1 { get; set; }
    [JsonPropertyName("strMeasure2")] public string? StrMeasure2 { get; set; }
    [JsonPropertyName("strMeasure3")] public string? StrMeasure3 { get; set; }
    [JsonPropertyName("strMeasure4")] public string? StrMeasure4 { get; set; }
    [JsonPropertyName("strMeasure5")] public string? StrMeasure5 { get; set; }
    [JsonPropertyName("strMeasure6")] public string? StrMeasure6 { get; set; }
    [JsonPropertyName("strMeasure7")] public string? StrMeasure7 { get; set; }
    [JsonPropertyName("strMeasure8")] public string? StrMeasure8 { get; set; }
    [JsonPropertyName("strMeasure9")] public string? StrMeasure9 { get; set; }
    [JsonPropertyName("strMeasure10")] public string? StrMeasure10 { get; set; }
    [JsonPropertyName("strMeasure11")] public string? StrMeasure11 { get; set; }
    [JsonPropertyName("strMeasure12")] public string? StrMeasure12 { get; set; }
    [JsonPropertyName("strMeasure13")] public string? StrMeasure13 { get; set; }
    [JsonPropertyName("strMeasure14")] public string? StrMeasure14 { get; set; }
    [JsonPropertyName("strMeasure15")] public string? StrMeasure15 { get; set; }
    public List<string>? MeasureList { get; set; }

    public Drink(string? strDrink, string? idDrink, string? strAlcoholic, string? strGlass, string? strInstructions,
        string? strIngredient1, string? strIngredient2, string? strIngredient3, string? strIngredient4,
        string? strIngredient5, string? strIngredient6, string? strIngredient7, string? strIngredient8,
        string? strIngredient9, string? strIngredient10, string? strIngredient11, string? strIngredient12,
        string? strIngredient13, string? strIngredient14, string? strIngredient15, string? strMeasure1,
        string? strMeasure2, string? strMeasure3, string? strMeasure4, string? strMeasure5, string? strMeasure6,
        string? strMeasure7, string? strMeasure8, string? strMeasure9, string? strMeasure10, string? strMeasure11,
        string? strMeasure12, string? strMeasure13, string? strMeasure14, string? strMeasure15)
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
        StrMeasure1 = strMeasure1;
        StrMeasure2 = strMeasure2;
        StrMeasure3 = strMeasure3;
        StrMeasure4 = strMeasure4;
        StrMeasure5 = strMeasure5;
        StrMeasure6 = strMeasure6;
        StrMeasure7 = strMeasure7;
        StrMeasure8 = strMeasure8;
        StrMeasure9 = strMeasure9;
        StrMeasure10 = strMeasure10;
        StrMeasure11 = strMeasure11;
        StrMeasure12 = strMeasure12;
        StrMeasure13 = strMeasure13;
        StrMeasure14 = strMeasure14;
        StrMeasure15 = strMeasure15;
        IngredientList = PopulateInstructionsList(this);
        MeasureList = PopulateMeasureList(this);
    }

    private static List<string>? PopulateMeasureList(Drink drink)
    {
        var measureList = new List<string>();
        var drinkType = drink.GetType();

        for (var i = 1; i <= 15; i++)
        {
            var measureProperty = drinkType.GetProperty($"StrMeasure{i}");
            if (measureProperty == null) continue;

            var measureValue = measureProperty.GetValue(drink) as string;
            if (!string.IsNullOrEmpty(measureValue))
            {
                measureList.Add(measureValue);
            }
        }

        return measureList;
    }


    private static List<string>? PopulateInstructionsList(Drink drink)
    {
        var instructionsList = new List<string>();
        var drinkType = drink.GetType();

        for (var i = 1; i <= 15; i++)
        {
            var ingredientProperty = drinkType.GetProperty($"StrIngredient{i}");
            if (ingredientProperty == null) continue;

            var ingredientValue = ingredientProperty.GetValue(drink) as string;
            if (!string.IsNullOrEmpty(ingredientValue))
            {
                instructionsList.Add(ingredientValue);
            }
        }

        return instructionsList;
    }


    public override string? ToString()
    {
        return StrDrink;
    }
}