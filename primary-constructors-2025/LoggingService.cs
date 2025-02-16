namespace PrimaryConstructors;

//mutable
public sealed class LoggingService(string logLevel)
{
    public void Log(string message)
        => Console.WriteLine($"[{logLevel}] {message}");
}

//immutable
public sealed class LoggingServiceOld
{
    private readonly string logLevel;

    public LoggingServiceOld(string logLevel)
        => this.logLevel = logLevel;

    public void Log(string message)
        => Console.WriteLine($"[{this.logLevel}] {message}");
}