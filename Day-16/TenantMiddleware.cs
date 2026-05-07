public class TenantMiddleware
{
    private readonly RequestDelegate _next;

    public TenantMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var tenant = context.Request.Headers["Tenant"];

        context.Items["Tenant"] = tenant;

        await _next(context);
    }
}