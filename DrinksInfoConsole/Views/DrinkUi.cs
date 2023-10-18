using DrinksInfoConsole.Models;
using Spectre.Console;

namespace DrinksInfoConsole.Views;

public class DrinkUi
{
    public void DisplayDrink(Drink? drink)
    {
        var panel = new Panel(new Rows(
            new Markup($"[bold]Drink Id:[/]\n{drink.IdDrink}"),
            new Markup($"[bold]Alcoholic:[/]\n{drink.StrAlcoholic}"),
            new Markup($"[bold]Glass:[/]\n{drink.StrGlass}"),
            new Markup($"[bold]Instructions:[/]\n{drink.StrInstructions}"),
            new Markup($"[bold]Ingredients:[/]\n{drink.StrIngredient1}")
        ));
        panel.Header = new PanelHeader($"{drink.StrDrink}");
        panel.Border = BoxBorder.Rounded;
        panel.Expand = true;
        AnsiConsole.Write(panel);
    }
}