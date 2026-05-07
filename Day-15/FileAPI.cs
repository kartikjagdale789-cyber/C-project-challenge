app.MapPost("/upload", async (IFormFile file) =>
{
    var path = Path.Combine("uploads", file.FileName);

    using var stream = new FileStream(path, FileMode.Create);
    await file.CopyToAsync(stream);

    return "File Uploaded";
});

app.MapGet("/download/{filename}", (string filename) =>
{
    var path = Path.Combine("uploads", filename);
    var bytes = File.ReadAllBytes(path);
    return Results.File(bytes, "application/octet-stream", filename);
});