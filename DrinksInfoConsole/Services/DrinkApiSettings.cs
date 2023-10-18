namespace DrinksInfoConsole.Services;

public class DrinkApiSettings
{
    public string BaseUrl { get; set; }
    public string ListCategoryEndpoint { get; set; }
    public string FilterByCategoryEndpoint { get; set; }
    public string DrinkByIdEndpoint { get; set; }
}