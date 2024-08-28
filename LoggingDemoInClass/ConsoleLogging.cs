namespace LoggingDemoInClass;

public static class ConsoleLogging
{
    [Obsolete(message: "This method is no longer used, now using Serilog", error: true)]
    public static void PassMessageToConsole(string message)
    {
        Console.WriteLine(message);
    }
}