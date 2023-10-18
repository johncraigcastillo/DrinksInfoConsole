using System.Text.Json;
using DrinksInfoConsole.Services;
using Microsoft.Extensions.Options;
using Spectre.Console;

namespace DrinksInfoConsole.Models;

internal interface IDrinkApi
{
    Task<Cocktail?> FetchSingleCocktail();
}

public class DrinkApi : IDrinkApi
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    private readonly string _listCategoryEndpoint;
    private readonly string _filterByCategoryEndpoint;
    private readonly string _drinkByIdEndpoint;


    public DrinkApi(HttpClient httpClient, IOptions<DrinkApiSettings> settings)
    {
        _httpClient = httpClient;
        _baseUrl = settings.Value.BaseUrl;
        _listCategoryEndpoint = settings.Value.ListCategoryEndpoint;
        _filterByCategoryEndpoint = settings.Value.FilterByCategoryEndpoint;
        _drinkByIdEndpoint = settings.Value.DrinkByIdEndpoint;
    }

    public async Task<Cocktail?> FetchSingleCocktail()
    {
        // todo: pass in id and put it where 11007 is
        var response = await _httpClient.GetAsync($"{_baseUrl}{_drinkByIdEndpoint}11007");
        if (response.IsSuccessStatusCode)
        {
            var responseData = await response.Content.ReadAsStringAsync();
            var cocktailList = JsonSerializer.Deserialize<CocktailList>(responseData);
            var cocktail = cocktailList?.Drinks.FirstOrDefault();
            return cocktail;
        }

        Console.WriteLine($"Error: {response.StatusCode}");
        return null;
    }
}