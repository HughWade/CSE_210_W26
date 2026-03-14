using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference();
        Console.WriteLine(reference1.DisplayReference());

        Scripture scripture1 = new Scripture();
        scripture1.DisplayScripture(5);

        Reference reference2 = new Reference("Helaman", 6, 36);
        Console.WriteLine(reference2.DisplayReference());

        Scripture scripture2 = new Scripture("And thus we see that the Lord began to pour out his Spirit upon the Lamanites, because of their easiness and willingness to believe in his words.");
        scripture2.DisplayScripture(3);
    }
}