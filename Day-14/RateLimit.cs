builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        opt.PermitLimit = 5;
        opt.Window = TimeSpan.FromSeconds(10);
    });
});

var app = builder.Build();

app.UseRateLimiter();

app.MapGet("/limited", () => "Rate Limited API")
.RequireRateLimiting("fixed");

app.Run();