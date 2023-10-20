using DrinksInfoConsole.Models;
using DrinksInfoConsole.Views;

namespace DrinksInfoConsole.Controllers;

public class ApiController
{
    private readonly IDrinkApi _drinkApi;


    public ApiController(IDrinkApi drinkApi, CategoryListUi categoryListUi)
    {
        _drinkApi = drinkApi;
    }

    public async Task<List<Category>?> GetCategoriesAsync()
    {
        return await _drinkApi.GetCategoriesAsync();
    }

    public async Task<List<Drink>?> GetDrinksByCategoryAsync(string category)
    {
        if (category == "Exit")
        {
            Environment.Exit(0);
        }

        return await _drinkApi.GetDrinksByCategoryAsync(category);
    }

    public async Task<Drink?> GetDrinkByIdAsync(string? userDrinkSelectionId)
    {
        return await _drinkApi.FetchSingleDrink(userDrinkSelectionId);
    }
}