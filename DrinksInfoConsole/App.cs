using DrinksInfoConsole.Controllers;
using DrinksInfoConsole.Models;
using DrinksInfoConsole.Views;
using Spectre.Console;

namespace DrinksInfoConsole;

public class App

{
    private readonly CategoryListUi _categoryListUi;
    private readonly ApiController _apiController;

    public App(CategoryListUi categoryListUi, ApiController apiController)
    {
        _categoryListUi = categoryListUi;
        _apiController = apiController;
    }

    public async Task RunAsync()
    {
        var categories = await _apiController.GetCategoriesAsync();
        var userCategorySelection = CategoryListUi.GetUserCategorySelection(categories);
        
        var drinks = await _apiController.GetDrinksByCategoryAsync(userCategorySelection);
        var userDrinkSelection = DrinkListUi.GetUserDrinkSelection(drinks);
        AnsiConsole.MarkupLine($"{userDrinkSelection.StrDrink}, {userDrinkSelection.IdDrink}");
        
    }
}