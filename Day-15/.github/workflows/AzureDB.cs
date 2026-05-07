builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        "Server=tcp:yourserver.database.windows.net;Database=yourdb;User Id=admin;Password=pass;"));