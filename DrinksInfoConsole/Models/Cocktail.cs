using System.Text.Json.Serialization;

namespace DrinksInfoConsole;

public class Cocktail
{
    public Cocktail(string strDrink)
    {
        StrDrink = strDrink;
    }

    [JsonPropertyName("strDrink")] public string StrDrink { get; set; }
}