string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
string resultTwo = string.Format("{0} {0} {0}", first, second);
Console.WriteLine(result);
Console.WriteLine(resultTwo);

decimal profits = 1000000000m;
Console.WriteLine($"{profits:N} were made from covered calls in your retirement years :_)");
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber:N3}");
Console.WriteLine($"       Sub Total: {subtotal:C}");
string tester = "Add padding to this";
Console.WriteLine(tester.PadLeft(45, '-'));
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

//
Console.WriteLine("Here's a quick comparison:\n");
//
string comparisonMessage = $"Dear {customerName},\nAs a customer of our Magic Yield offering we are excited to tell you about a new financi\n\nCurrently you own {currentShares}";
//
// // Your logic here
//
Console.WriteLine(comparisonMessage);
