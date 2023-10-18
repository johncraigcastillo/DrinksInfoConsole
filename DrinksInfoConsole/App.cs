using DrinksInfoConsole.Controllers;
using DrinksInfoConsole.Models;
using DrinksInfoConsole.Views;
using Spectre.Console;

namespace DrinksInfoConsole;

public class App

{
    private readonly ApiController _apiController;
    private readonly DrinkUi _drinkUi;

    public App(ApiController apiController, DrinkUi drinkUi)
    {
        _apiController = apiController;
        _drinkUi = drinkUi;
    }

    public async Task RunAsync()
    {
        var categories = await _apiController.GetCategoriesAsync();
        var userCategorySelection = CategoryListUi.GetUserCategorySelection(categories);

        var drinks = await _apiController.GetDrinksByCategoryAsync(userCategorySelection);
        var userDrinkSelectionId = DrinkListUi.GetUserDrinkSelection(drinks);
        
        var drink = await _apiController.GetDrinkByIdAsync(userDrinkSelectionId);
        
        _drinkUi.DisplayDrink(drink);
    }
}