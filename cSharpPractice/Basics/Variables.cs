namespace Basics;

public static class Variables
{
    public static void Run()
    {
        string name = "Bob";
        int messagesTotal = 3;
        double temp = 34.4;

        Console.Write("Hello, " + name + "! You have " + messagesTotal + " messages in your inbox.  The temperature is " + temp + " celsius.\n");
        Console.WriteLine("Challenge Accepted");
        Console.WriteLine("test\tyour\tmight");
        
        string projectName = "ACME";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        Console.WriteLine("View English output");
        Console.WriteLine($"\tc:\\Exercise\\{projectName}\\data.txt");

        Console.WriteLine(russianMessage);
        Console.WriteLine($"\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");
    }
}