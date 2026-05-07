using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

class APM
{
    static void Main()
    {
        var config = TelemetryConfiguration.CreateDefault();
        config.ConnectionString = "InstrumentationKey=your_key";

        var client = new TelemetryClient(config);

        client.TrackEvent("App Started");
        client.TrackException(new Exception("Test Error"));

        Console.WriteLine("Telemetry Sent");
    }
}