using RestSharp;
using SearchCep.Models;
using System.Text.Json;
using static System.Console;

namespace SearchCep
{
    public class RequestRestSharp
    {
        public static async Task ExecuteGetAsync(string url)
        {
            WriteLine("\nRestSharp: ");
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Get);
                RestResponse response = await client.ExecuteAsync(request);
                WriteLine($"Response: {response.Content}");
                Cep cep = JsonSerializer.Deserialize<Cep>(response.Content);
                WriteLine($"Only Uf: {cep.uf}");
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }
        }
    }
}
