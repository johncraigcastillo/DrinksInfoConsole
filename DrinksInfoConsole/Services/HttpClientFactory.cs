using System.Net.Http.Headers;

namespace DrinksInfoConsole.Services;

public class HttpClientFactory
{
    private HttpClient Client { get; set; }

    public HttpClientFactory()
    {
        Client = new HttpClient();
        ConfigureClient();
    }

    private void ConfigureClient()
    {
        Client.DefaultRequestHeaders.Accept.Clear();
        Client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        
        
    }

    public HttpClient GetClient()
    {
        return Client;
    }
}