using DrinksInfoConsole.Models;
using DrinksInfoConsole.Services;
using DrinksInfoConsole.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DrinksInfoConsole;

public class Program
{
    private static async Task Main(string[] args)
    {
        var serviceProvider = ConfigureServices();
        // var httpClient = serviceProvider.GetService<HttpClient>();
        // var api = serviceProvider.GetService<IDrinkApi>();
        // var cocktail = await api.FetchSingleCocktail();
        // Console.WriteLine(cocktail.StrDrink);
        var app = serviceProvider.GetService<App>();
        app.Run();
        

    }

    private static IServiceProvider ConfigureServices()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var services = new ServiceCollection();


        services.Configure<DrinkApiSettings>(configuration.GetSection("DrinkApiSettings"));
        services.AddSingleton<HttpClient>();
        services.AddSingleton<IDrinkApi, DrinkApi>();
        services.AddSingleton<App>();

        return services.BuildServiceProvider();
    }
}