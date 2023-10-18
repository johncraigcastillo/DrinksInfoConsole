using System.Text.Json;
using DrinksInfoConsole.Services;
using Microsoft.Extensions.Options;
using Spectre.Console;

namespace DrinksInfoConsole.Models;

public interface IDrinkApi
{
    Task<List<Category>?> GetCategoriesAsync();
    Task<List<Drink>?> GetDrinksByCategoryAsync(string category);
    Task<Drink?> FetchSingleDrink(string? id);
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

    public async Task<Drink?> FetchSingleDrink(string? id)
    {
        var response = await _httpClient.GetAsync($"{_baseUrl}{_drinkByIdEndpoint}{id}");
        if (response.IsSuccessStatusCode)
        {
            var responseData = await response.Content.ReadAsStringAsync();
            var cocktailList = JsonSerializer.Deserialize<DrinkList>(responseData);
            var cocktail = cocktailList?.Drinks.FirstOrDefault();
            return cocktail;
        }

        Console.WriteLine($"Error: {response.StatusCode}");
        return null;
    }

    public async Task<List<Category>?> GetCategoriesAsync()
    {
        var response = await _httpClient.GetAsync($"{_baseUrl}{_listCategoryEndpoint}");
        if (response.IsSuccessStatusCode)
        {
            var responseData = await response.Content.ReadAsStringAsync();
            var categoryListObject = JsonSerializer.Deserialize<CategoryList>(responseData);
            var categoryList = categoryListObject?.Drinks;


            return categoryList;
        }

        Console.WriteLine($"Error: {response.StatusCode}");
        return null;
    }

    public async Task<List<Drink>?> GetDrinksByCategoryAsync(string category)
    {
        var response = await _httpClient.GetAsync($"{_baseUrl}{_filterByCategoryEndpoint}{category}");
        if (response.IsSuccessStatusCode)
        {
            var responseData = await response.Content.ReadAsStringAsync();
            var drinkListObject = JsonSerializer.Deserialize<DrinkList>(responseData);
            var drinkList = drinkListObject?.Drinks;


            return drinkList;
        }

        Console.WriteLine($"Error: {response.StatusCode}");
        return null;
    }
}