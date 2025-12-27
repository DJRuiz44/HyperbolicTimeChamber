// See https://aka.ms/new-console-template for more information
int first = 0;
int food = 2;
string testing = first.ToString() + food.ToString();
Console.WriteLine(testing);

string stringNumA = "1";
string stringNumB = "2";
int result = int.Parse(stringNumA) + int.Parse(stringNumB);
Console.WriteLine(result);

int converted = Convert.ToInt32(stringNumA);
int convertedB = Convert.ToInt32(stringNumB);
Console.WriteLine(stringNumA);
Console.WriteLine(stringNumB + stringNumA);
Console.WriteLine(converted + convertedB);

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = value1 + Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");