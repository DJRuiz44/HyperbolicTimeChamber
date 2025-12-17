namespace Basics;

public static class Operators 
{
    public static void Run()
    {
        int fahrenheit = 94;
        decimal celsius = fahrenheit - 32 * (5/9);
        Console.WriteLine($"The temperature is {celsius} Celsius");
    }
}