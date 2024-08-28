using Serilog;

namespace LoggingDemoInClass;

public class Calculator
{
    public Calculator()
    {
        Log.Information("Calculator Created");
    }
    
    public double Add(double x, double y)
    {
        Log.Information("Add method called, parameter x is {x} parameter y is {y}", x, y);
        return x + y;
    }

    public double Substract(double x, double y)
    {
        Log.Information("Subtract method called, parameter x is {x} parameter y is {y}", x, y);
        return x - y;
    }
}