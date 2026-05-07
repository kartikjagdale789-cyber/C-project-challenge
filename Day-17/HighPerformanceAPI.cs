using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/data", async () =>
{
    await Task.Delay(10); // simulate async work
    return Results.Ok(new { Message = "High Performance API Response" });
});

app.Run();