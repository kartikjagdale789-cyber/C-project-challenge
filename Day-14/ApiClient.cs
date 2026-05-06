using System;
using System.Net.Http;
using System.Threading.Tasks;

class ApiClient
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();

        var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
        var data = await response.Content.ReadAsStringAsync();

        Console.WriteLine(data);
    }
}