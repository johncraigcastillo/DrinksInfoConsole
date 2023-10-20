using DrinksInfoConsole.Models;
using Spectre.Console;

namespace DrinksInfoConsole.Views;

public class DrinkUi
{
    public void DisplayDrink(Drink? drink)
    {
        var panel = new Panel(new Rows(
                new Markup($"[bold blue]Drink Id:[/]\n{drink.IdDrink}"),
                new Markup($"[bold blue]Alcoholic:[/]\n{drink.StrAlcoholic}"),
                new Markup($"[bold blue]Glass:[/]\n{drink.StrGlass}"),
                new Markup($"[bold blue]Ingredients:[/]\n{string.Join("\n", drink.IngredientList)}"),
                new Markup($"[bold blue]Instructions:[/]\n{drink.StrInstructions}")
            ))
            {
                Header = new PanelHeader($"{drink.StrDrink}"),
                Expand = true
            }
            ;
        AnsiConsole.Write(panel);
    }
}