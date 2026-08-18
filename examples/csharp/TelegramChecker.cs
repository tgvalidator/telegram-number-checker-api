using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class TelegramChecker
{
    static async Task Main()
    {
        var apiKey = Environment.GetEnvironmentVariable("TGVALIDATOR_API_KEY")
            ?? throw new Exception("Set TGVALIDATOR_API_KEY");
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
        var content = new StringContent("{\"service_type\":\"tg\",\"identifier\":\"+14155550100\"}", Encoding.UTF8, "application/json");
        var response = await client.PostAsync("https://tgvalidator.com/api/v1/check", content);
        var body = await response.Content.ReadAsStringAsync();
        response.EnsureSuccessStatusCode();
        Console.WriteLine(body);
    }
}
