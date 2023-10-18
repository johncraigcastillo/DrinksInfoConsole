using System.Text.Json.Serialization;

namespace DrinksInfoConsole.Models;

public class CategoryList
{
    [JsonPropertyName("drinks")] public List<Category>? Drinks { get; set; }
}