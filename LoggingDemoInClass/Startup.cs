// You must install the Serilog Nuget package,
// as well as, Serilog.Sinks.Console and Serilog.Sinks.File
using Serilog;

namespace LoggingDemoInClass;

/// <summary>
/// The sole purpose of this class is to have the Initialize method called to configure our logger.
/// </summary>
public class Startup
{
    /// <summary>
    /// This method will configure the logger.
    /// </summary>
    public static void InitializeLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information() // Setting the default log level, anything under it will be ignored
            .WriteTo.Console() // Adding the ability for console logging
            .WriteTo.File(
                "logs/LoggingDemoLog-.txt", // Adding the ability of writing logs to a file to a desired file path
                rollingInterval: RollingInterval.Day // setting the logger to create one file per day
                ) 
            .CreateLogger(); // Creating the logger
    }
}