using DrinksInfoConsole.Models;
using Spectre.Console;

namespace DrinksInfoConsole.Views;

public class CategoryListUi
{
    public static string GetUserCategorySelection(IEnumerable<Category>? categories)
    {
        var userSelection = AnsiConsole.Prompt(new SelectionPrompt<string>()
            .Title("Select a category")
            .AddChoices(categories.Select(x => x.StrCategory.ToString()))
        );
        return userSelection;
    }
}