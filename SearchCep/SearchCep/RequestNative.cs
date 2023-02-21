using static System.Console;

namespace SearchCep
{
    public class RequestNative
    {
        public static async Task Execute(string url)
        {
            WriteLine("\nHttpCliente: ");
            using var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = httpClient.Send(request);
            using var reader = new StreamReader(response.Content.ReadAsStream());
            var responseBody = reader.ReadToEnd();
            WriteLine(responseBody);
        }
    }
}
