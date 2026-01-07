string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
string resultTwo = string.Format("{0} {0} {0}", first, second);
Console.WriteLine(result);
Console.WriteLine(resultTwo);

decimal profits = 1000000000m;
Console.WriteLine($"{profits:N} were made from covered calls in your retirement years :_)");
