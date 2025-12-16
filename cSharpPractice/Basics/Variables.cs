namespace Basics;

public static class Variables
{
    public static void Run()
    {
        string name = "Bob";
        int messagesTotal = 3;
        double temp = 34.4;

        Console.Write("Hello, " + name + "! You have " + messagesTotal + " messages in your inbox.  The temperature is " + temp + " celsius.");
    }
}