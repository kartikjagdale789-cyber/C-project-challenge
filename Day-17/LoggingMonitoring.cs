using Microsoft.Extensions.Logging;

class LoggingMonitoring {
    static void Main() {
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        ILogger logger = loggerFactory.CreateLogger<LoggingMonitoring>();

        logger.LogInformation("Application Started");
        logger.LogWarning("This is a warning");
        logger.LogError("This is an error");
    }
}