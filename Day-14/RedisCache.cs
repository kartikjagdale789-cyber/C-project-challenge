builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});

app.MapGet("/cache", async (IDistributedCache cache) =>
{
    var data = await cache.GetStringAsync("key");

    if (data == null)
    {
        data = "Cached Data";
        await cache.SetStringAsync("key", data);
    }

    return data;
});