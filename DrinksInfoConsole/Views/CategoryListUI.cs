using DrinksInfoConsole.Models;
using Spectre.Console;

namespace DrinksInfoConsole.Views;

public class CategoryListUi
{
    private readonly List<Category> _categories;

    public CategoryListUi(List<Category> categories)
    {
        _categories = categories;
    }

    public void DisplayCategoryList()
    {
        var table = new Table();
        table.AddColumn("Category");
        foreach (var category in _categories)
        {
            table.AddRow(category.StrCategory);
        }

        AnsiConsole.Write(table);
    }
    
}