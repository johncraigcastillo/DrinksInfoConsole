using DrinksInfoConsole.Models;
using DrinksInfoConsole.Views;

namespace DrinksInfoConsole.Controllers;

public class CategoriesController
{
    private DrinkApi _drinkApi;
    private CategoryListUi _categoryListUi;


    public CategoriesController(DrinkApi drinkApi, CategoryListUi categoryListUi)
    {
        _drinkApi = drinkApi;
        _categoryListUi = categoryListUi;
    }

    public void DisplayCategories()
    {
        throw new NotImplementedException();
    }
}