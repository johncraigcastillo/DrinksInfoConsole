using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class Category
{
    public Category(string strCategory)
    {
        StrCategory = strCategory;
    }

    [JsonPropertyName("strCategory")] public string StrCategory { get; set; }
}