using Serilog;

namespace LoggingDemoInClass;

public class DataAccess
{
    public static List<int> LoadData()
    {
        var connString = "connection1 to data source";
        Log.Debug("The conn string is {connString}", connString); // Ignored since min level is Information
        
        // Ensure you do not use string interpolation in the message template!!!
        Log.Information("Loading data from data source with the connection: {connString}", connString);
        
        var data = new List<int> { 1, 2, 3 };
        
        // To use structured data and retain the object format, use @ in the param name
        Log.Information("Data loaded: {@data}", data);

        return data;
    }

    public static void SaveData(List<int> data)
    {
        Log.Information("Beginning to save data");
        
        if (data is null)
        {
            // This will be logged since Warning is higher than Infomation
            // Logging an error - no crash but bad results
            Log.Error("The data is empty, nothing saved");
            return;
        }

        if (data.Count < 2)
        {
            // This will be logged since Warning is higher than Information
            // Logging warning - could be an error but demoing warning here
            Log.Warning("The data is too short, nothing saved, data set: {@data}", data);
            return;
        }
        
        Log.Information("Saving data to data source: {@data}", data);
    }
}