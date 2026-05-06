builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("your_connection_string"));

app.MapGet("/students", async (AppDbContext db) =>
    await db.Students.ToListAsync());