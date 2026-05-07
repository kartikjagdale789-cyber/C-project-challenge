builder.Services.AddAuthentication()
    .AddGoogle(options =>
    {
        options.ClientId = "your_client_id";
        options.ClientSecret = "your_secret";
    });

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/", () => "OAuth Login");