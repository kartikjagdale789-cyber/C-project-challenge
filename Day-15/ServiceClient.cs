using System.Net.Http;

var client = new HttpClient();

var response = await client.GetAsync("https://localhost:5001/api/data");
var data = await response.Content.ReadAsStringAsync();

Console.WriteLine(data);