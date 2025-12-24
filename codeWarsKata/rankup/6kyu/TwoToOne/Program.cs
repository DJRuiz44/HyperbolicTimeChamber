string TwoToOne(string stringA, string stringB)
{
    Dictionary<char, int> counter = new Dictionary<char, int>();
    char[] sortedA = stringA.ToCharArray();
    char[] sortedB = stringB.ToCharArray();



    foreach (char letter in stringA)
    {
        Console.WriteLine("fking");
        if (counter.ContainsKey(letter))
        {
            counter[letter] += 1;
        }
        else
        {
            counter[letter] = 1;
        }
    }
    foreach (char letter in stringB)
    {
        Console.WriteLine("fking");
        if (counter.ContainsKey(letter))
        {
            counter[letter] += 1;
        }
        else
        {
            counter[letter] = 1;
        }
    }

    string returnStr = "";
    foreach (char key in counter.Keys.OrderBy(c => c))
    {
        returnStr += key;
        Console.WriteLine($"{key}: {counter[key]}");
    }
    Console.WriteLine(counter.Count);
    return returnStr;
}
string result = TwoToOne("aretheyhere", "yestheyarehere"); //aehrsty
Console.WriteLine(result);