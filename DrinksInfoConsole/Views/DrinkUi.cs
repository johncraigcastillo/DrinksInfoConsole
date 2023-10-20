using DrinksInfoConsole.Models;
using Spectre.Console;

namespace DrinksInfoConsole.Views;

public class DrinkUi
{
    public void DisplayDrink(Drink? drink)
    {
        var table = new Table();
        table.AddColumn("Ingredient");
        table.AddColumn("Measure");
        for (var i = 0; i < drink.IngredientList.Count; i++)
        {
            table.AddRow(drink.IngredientList[i], drink.MeasureList[i]);
        }

        var panel = new Panel(new Rows(
                new Markup($"[bold blue]Drink Id:[/]\n{drink.IdDrink}"),
                new Markup($"[bold blue]Alcoholic:[/]\n{drink.StrAlcoholic}"),
                new Markup($"[bold blue]Glass:[/]\n{drink.StrGlass}"),
                new Markup($"[bold blue]Ingredients & Measures:[/]"),
                table,
                new Markup($"[bold blue]Instructions:[/]\n{drink.StrInstructions}")
            ))
            {
                Header = new PanelHeader($"{drink.StrDrink}"),
                Expand = true
            }
            ;
        AnsiConsole.Write(panel);
        AnsiConsole.MarkupLine("[bold blue]Press any key to go back to the Main Menu[/]");
        Console.ReadKey();
    }
}