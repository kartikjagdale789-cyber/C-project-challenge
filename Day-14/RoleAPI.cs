app.MapGet("/admin", () => "Admin Data")
.RequireAuthorization(policy => policy.RequireRole("Admin"));