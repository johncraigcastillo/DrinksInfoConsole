using DrinksInfoConsole.Models;
using Spectre.Console;

namespace DrinksInfoConsole.Views;

public class CategoryListUi
{
    public static string GetUserCategorySelection(IEnumerable<Category>? categories)
    {
        var categoryNames = categories.Select(x => x.StrCategory.ToString());
        var choices = categoryNames.Prepend("Exit");
        var userSelection = AnsiConsole.Prompt(new SelectionPrompt<string>()
            .Title("Select a category")
            .AddChoices(choices)
        );
        return userSelection;
    }
}