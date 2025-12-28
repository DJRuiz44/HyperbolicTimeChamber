// See https://aka.ms/new-console-template for more information
Muscle Shoulder = new Muscle("Supraspinatus", "Supraspinous process of the greater tubercle of the humerus", "Superior facet of the greater tubercle of the humerus", "First 10-15 degrees of abduction", "C5-C6 SupraScapular Nerve");
Shoulder.Print();
class Muscle
{
    public string Name { get; set; }
    public string Origin { get; set; }
    public string Insertion { get; set; }
    public string Action { get; set; }

    public string Innervation { get; set; }

    public void Print()
    {
        Console.WriteLine($"Muscle Name:\t\t{Name}");
        Console.WriteLine($"Origin:\t\t{Origin}");
    }

    public Muscle(string name, string origin, string insertion, string action, string innervation)
    {
        Name = name;
        Origin = origin;
        Insertion = insertion;
        Action = action;
        Innervation = innervation;
    }
}
