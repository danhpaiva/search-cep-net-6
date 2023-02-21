using SearchCep;
using static System.Console;

WriteLine("\n\tWelcome!!!");
Write("Please... Enter your CEP: ");
string cep = ReadLine();
string url = $"https://viacep.com.br/ws/{cep}/json/";

RequestNative.Execute(url);
RequestRestSharp.ExecuteGetAsync(url);

ReadLine();