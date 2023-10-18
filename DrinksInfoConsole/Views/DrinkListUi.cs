using DrinksInfoConsole.Models;
using Spectre.Console;

namespace DrinksInfoConsole.Views;

public class DrinkListUi
{
    public static Drink GetUserDrinkSelection(IEnumerable<Drink>? drinks)
    {
        
        var userSelection = AnsiConsole.Prompt(new SelectionPrompt<Drink>()
            .Title("Select a drink")
            .AddChoices(drinks)
        );
        return userSelection;
    }
}