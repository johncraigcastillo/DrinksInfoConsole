using DrinksInfoConsole.Controllers;
using DrinksInfoConsole.Models;
using DrinksInfoConsole.Services;
using DrinksInfoConsole.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DrinksInfoConsole;

public static class Program
{
    private static async Task Main(string[] args)
    {
        var serviceProvider = ConfigureServices();
        var app = serviceProvider.GetService<App>();
        await app.RunAsync();
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
        services.AddSingleton<ApiController>();
        services.AddSingleton<CategoryListUi>();
        services.AddSingleton<App>();

        return services.BuildServiceProvider();
    }
}