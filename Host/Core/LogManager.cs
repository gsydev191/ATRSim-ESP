using Serilog;

namespace Host;

public static class LogManager
{
    private static readonly ILogger Logger;

    static LogManager()
    {
        Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
    }

    public static void Info(string message)
    {
        Logger.Information(message);
    }

    public static void Error(string message)
    {
        Logger.Error(message);
    }

    public static void Error(string message, Exception exception)
    {
        Logger.Error(exception, message);
    }

    public static void Warning(string message)
    {
        Logger.Warning(message);
    }

    public static void Fatal(string message)
    {
        Logger.Fatal(message);
    }

    public static void Debug(string message)
    {
        Logger.Debug(message);
    }

}