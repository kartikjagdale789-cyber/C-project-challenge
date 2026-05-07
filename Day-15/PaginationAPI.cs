app.MapGet("/students", (AppDbContext db, int page = 1, int pageSize = 5, string? name = null) =>
{
    var query = db.Students.AsQueryable();

    if (!string.IsNullOrEmpty(name))
        query = query.Where(s => s.Name.Contains(name));

    var result = query
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToList();

    return result;
});