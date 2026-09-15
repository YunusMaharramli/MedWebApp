namespace WebMedApp;

public sealed record TestEndpointResponse(
    string Api,
    string Version,
    string Message,
    DateTimeOffset TimestampUtc);
