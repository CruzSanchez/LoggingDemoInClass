using Serilog;

namespace LoggingDemoInClass;

class Program
{
    static void Main(string[] args)
    {
        Startup.InitializeLogger();
        
        Log.Information("Application started");
        
        Calculator calc = new();
        
        var result = calc.Add(1, 2);
        Log.Information("Result returned: {result}", result);
        
        result = calc.Substract(2, 5);
        Log.Information("Result returned: {result}", result);

        var data = DataAccess.LoadData();

        data[0] = 100;
        
        DataAccess.SaveData(data); // Good path
        Console.ReadLine();

        DataAccess.SaveData(null); // Bad path (null data)
        Console.ReadLine();

        DataAccess.SaveData(new List<int>() {1}); // Bad path (low count data)
        
        Console.ReadLine();
        Log.Information("Application terminating successfully");
    }
}